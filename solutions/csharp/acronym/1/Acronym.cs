using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        //phrase.Replace('_', ' ');

        //string[] newPhrase = phrase.Split(['|', '-',  ' ']);

        //return newPhrase.Aggregate("", (current, element) => current + element[0]).ToUpper();

        char[] separators = [' ', '_', '-'];

        string acronym = string.Join("", phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(ch => ch[0]));

        return acronym.ToUpper();
    }
}