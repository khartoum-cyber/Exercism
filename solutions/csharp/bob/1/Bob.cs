using System.Linq;

public static class Bob
{
    public static string Response(string statement) => statement switch
    {
        not null when string.IsNullOrWhiteSpace(statement) => "Fine. Be that way!",
        not null when IsQuestion(statement) && IsYelling(statement) => "Calm down, I know what I'm doing!",
        not null when IsYelling(statement) => "Whoa, chill out!",
        not null when IsQuestion(statement.Trim()) => "Sure.",
        _ => "Whatever."
    };

    private static bool IsQuestion(string phrase) => phrase.EndsWith('?');
    private static bool IsYelling(string phrase)
    { 
        bool letterFound = false;
        foreach (var ch in phrase.Where(char.IsLetter))
        {
            if (char.IsLower(ch))
                return false;
            letterFound = true;
        }
        return letterFound;
    }
}