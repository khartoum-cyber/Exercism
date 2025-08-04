using System.Collections.Generic;
using System.Linq;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        List<string> proverb = [];

        proverb.AddRange(subjects.Select((t, i) => i == subjects.Length - 1 ? $"And all for the want of a {subjects[0]}." : $"For want of a {t} the {subjects[i + 1]} was lost."));

        return proverb.ToArray();
    }
}