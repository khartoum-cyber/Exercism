public static class ResistorColorDuo
{
        private static readonly List<string> ColorValues = new() { "black" , "brown" , "red" , "orange" , "yellow" , "green" , "blue" , "violet" , "grey" , "white" };
    
    public static int Value(string[] colors)
    {
        return ColorValues.IndexOf(colors[0]) * 10 + ColorValues.IndexOf(colors[1]);
    }
}
