using System.Collections.Generic;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> proverb = [];

        for (int i = 0; i < subjects.Length; i++)
        {
            proverb.Add(i == subjects.Length - 1 ? $"And all for the want of a {subjects[0]}." : $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.");
        }

        return proverb.ToArray();
    }
}