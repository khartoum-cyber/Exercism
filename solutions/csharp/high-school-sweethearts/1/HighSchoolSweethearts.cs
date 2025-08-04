using System;
using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB) => $"                  {studentA} \u2661 {studentB}                    ";

    public static string DisplayBanner(string studentA, string studentB) => $"     ******       ******\n   **      **   **      **\n **         ** **         **\n**            *            **\n**                         **\n**     {studentA} +  {studentB}    **\n **                       **\n   **                   **\n     **               **\n       **           **\n         **       **\n           **   **\n             ***\n              *";

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours) => string.Format(CultureInfo.CreateSpecificCulture("de-DE"),
        "{0} and {1} have been dating since {2:d} - that's {3:n2} hours", studentA, studentB, start, hours);
}
