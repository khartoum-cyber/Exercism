using System.Linq;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey) => text.Aggregate(string.Empty, (current, ch) => current + Cipher(ch, shiftKey));

    private static char Cipher(char ch, int key)
    {
        if (!char.IsLetter(ch))
            return ch;

        char offset = char.IsUpper(ch) ? 'A' : 'a';
        return (char)((((ch + key) - offset) % 26) + offset);
    }
}