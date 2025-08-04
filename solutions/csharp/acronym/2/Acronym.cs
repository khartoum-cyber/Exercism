public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        bool isSeparator = true;
        var acronym = "";

        foreach (var ch in phrase.ToUpper())
        {
            if (ch is '-' or ' ')
                isSeparator = true;
            else
            {
                if (isSeparator)
                {
                    if (char.IsLetter(ch))
                    {
                        acronym += ch;
                        isSeparator = false;
                    }
                }
            }
        }
        return acronym;
    }
}