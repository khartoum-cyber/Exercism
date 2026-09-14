public static class LineUp
{
    public static string Format(string name, int number) => $"{name}, you are the {number}{Suffix(number)} customer we serve today. Thank you!";

    private static string Suffix(int number)
    {
        int lastDigit = number % 10;
        int lastTwoDigits = number % 100;

        return (lastTwoDigits, lastDigit) switch
        {
            (11, _) => "th",
            (12, _) => "th",
            (13, _) => "th",
            (_, 1)  => "st",
            (_, 2)  => "nd",
            (_, 3)  => "rd",
            _       => "th"
        };
    }
}