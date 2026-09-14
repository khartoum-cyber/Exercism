public static class ReverseString
{
    public static string Reverse(string input)
    {
        return Rec(input, input.Length - 1);
    }

    private static string Rec(string str, int index)
    {
        if(index < 0)
            return "";

        return str[index] + Rec(str, index - 1);
    }
}