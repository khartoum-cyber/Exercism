public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        // Decide the minimal type and payload size
        bool isSigned;
        int payloadBytes;

        if (reading >= 0)
        {
            if (reading <= 65_535L)
            {
                // ushort (2 bytes, unsigned)
                isSigned = false;
                payloadBytes = 2;
            }
            else if (reading <= 2_147_483_647L)
            {
                // int (4 bytes, signed)
                isSigned = true;
                payloadBytes = 4;
            }
            else if (reading <= 4_294_967_295L)
            {
                // uint (4 bytes, unsigned)
                isSigned = false;
                payloadBytes = 4;
            }
            else
            {
                // long (8 bytes, signed)
                isSigned = true;
                payloadBytes = 8;
            }
        }
        else
        {
            if (reading >= -32_768L)
            {
                // short (2 bytes, signed)
                isSigned = true;
                payloadBytes = 2;
            }
            else if (reading >= -2_147_483_648L)
            {
                // int (4 bytes, signed)
                isSigned = true;
                payloadBytes = 4;
            }
            else
            {
                // long (8 bytes, signed)
                isSigned = true;
                payloadBytes = 8;
            }
        }

        // Prefix byte per protocol:
        // - Unsigned: prefix = payloadBytes
        // - Signed:   prefix = 256 - payloadBytes
        byte prefix = isSigned
            ? (byte)(256 - payloadBytes)
            : (byte)payloadBytes;

        // Get 8-byte little-endian representation of the long
        // BitConverter on Windows/.NET is little-endian on most platforms;
        // we keep it as-is because the protocol expects little-endian payload.
        var allBytesLe = BitConverter.GetBytes(reading);

        // Build the 9-byte buffer: [prefix][payload][zero-padding...]
        var buffer = new byte[9];
        buffer[0] = prefix;

        // Copy only the least-significant 'payloadBytes' (little-endian)
        Array.Copy(allBytesLe, 0, buffer, 1, payloadBytes);

        // Remaining bytes (if any) are kept as zero per internal buffer contract
        return buffer;

    }

    public static long FromBuffer(byte[] buffer) => buffer[0] switch    
    {
        256 - 8 or 4 or 2 => BitConverter.ToInt64(buffer, 1),
        256 - 4 => BitConverter.ToInt32(buffer, 1),
        256 - 2 => BitConverter.ToInt16(buffer, 1),
        _ => 0,   
    };
}
