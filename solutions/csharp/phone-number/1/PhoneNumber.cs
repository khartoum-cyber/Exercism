using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var result = string.Join("", phoneNumber.ToCharArray().Where(char.IsDigit));

        if (result.Length is < 10 or > 11)
            throw new ArgumentException();

        if (result.Length == 11)
            result = result[0] == '1' ? result.Remove(0, 1) : throw new ArgumentException();

        return result[0] == '0' || result[0] == '1' || result[3] == '0' || result[3] == '1'
            ? throw new ArgumentException()
            : result;
    }
}