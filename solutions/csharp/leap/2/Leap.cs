public static class Leap
{
    public static bool IsLeapYear(int year) => (year % 4, year % 100, year % 400) switch
    {
        (_, 0, 0) => true,
        (_, 0, _) => false,
        (0, _, _) => true,
        _ => false
    };
}