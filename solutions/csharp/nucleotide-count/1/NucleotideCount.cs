using System;
using System.Collections.Generic;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var dictionary = new Dictionary<char, int>{ ['A'] = 0, ['C'] = 0, ['G'] = 0, ['T'] = 0 };

        foreach (char c in sequence)
        {
            switch (c)
            {
                case 'A':
                    dictionary[c] += 1;
                    break;
                case 'C':
                    dictionary[c] += 1;
                    break;
                case 'G':
                    dictionary[c] += 1;
                    break;
                case 'T':
                    dictionary[c] += 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        return dictionary;
    }
}