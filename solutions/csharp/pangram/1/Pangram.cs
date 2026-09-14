public static class Pangram
{
    public static bool IsPangram(string input)
    {
        int[] freq = new int[26];

        for(int i = 0; i < input.Length; i++)
        {
            if(char.IsLetter(input[i]))
            {
                freq[char.ToLower(input[i]) - 'a']++;
            }
        }

        foreach(var elem in freq)
        {
            if(elem == 0)
                return false;
        }

        return true;
    }
}
