using System.Globalization;

public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB) => $"{studentA,29} ♡ {studentB,-29}";

    public static string DisplayBanner(string studentA, string studentB)
    {
        return @"
     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     L. G.  +  P. R.     **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *
            ";
    }

    public static string DisplayGermanExchangeStudents(string studentA, string studentB, DateTime start, float hours)
    {
        CultureInfo german = new("de-DE");

        return String.Format(german, "{0} and {1} have been dating since {2:d} - that's {3:N2} hours", studentA, studentB, start, hours);
    }
}
