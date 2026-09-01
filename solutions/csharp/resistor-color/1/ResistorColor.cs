public static class ResistorColor
{
    private static readonly List<string> colors = new() { "black" , "brown" , "red" , "orange" , "yellow" , "green" , "blue" , "violet" , "grey" , "white" };
    
    public static int ColorCode(string color) => colors.IndexOf(color);

    public static string[] Colors() => colors.ToArray();
}