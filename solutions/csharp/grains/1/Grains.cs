using System;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n is <= 0 or > 64)
            throw new ArgumentOutOfRangeException();

        ulong result = 1;

        for (int i = 1; i < n; i++)
            result *= 2;

        return result;
    }

    public static ulong Total()
    {
        ulong total = 0;

        for (int i = 1; i <= 64; i++)
        {
            total += Square(i);
        }

        return total;
    }
}