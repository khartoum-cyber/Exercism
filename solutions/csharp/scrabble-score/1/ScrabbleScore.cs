using System;
using System.Collections.Generic;
using System.Linq;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        var letterScores = new Dictionary<string, int> { ["AEIOULNRST"] = 1, ["DG"] = 2, ["BCMP"] = 3, ["FHVWY"] = 4, ["K"] = 5, ["JX"] = 8, ["QZ"] = 10 };

        return input.Select(ch => letterScores.First(kvp => kvp.Key.Contains(char.ToUpper(ch))).Value).Sum();
    }
}