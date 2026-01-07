public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter) => str.Split(delimiter)[1];

    public static string SubstringBetween(this string str, string delimiter1, string delimiter2)
    {
        int startIndex = str.IndexOf(delimiter1);
        int endIndex = str.IndexOf(delimiter2);

        return str.Substring(startIndex + delimiter1.Length, endIndex - (startIndex + delimiter1.Length));
    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str) => str.Split(':')[1].Trim();
    
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str) => str.Split(':')[0].Trim('[',']');
}