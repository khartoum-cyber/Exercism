public static class ResistorColorTrio
{
    private static readonly List<string> ColorValues = new()
    {
        "black", "brown", "red", "orange", "yellow",
        "green", "blue", "violet", "grey", "white"
    };
    
    public static string Label(string[] colors)
    {
        long value = (ColorValues.IndexOf(colors[0]) * 10L + ColorValues.IndexOf(colors[1]));

        int multiplier = ColorValues.IndexOf(colors[2]);

        value *= (long)Math.Pow(10, multiplier);

        return value switch
        {
            >= 1_000_000_000 => $"{value / 1_000_000_000} gigaohms",
            >= 1_000_000 => $"{value / 1_000_000} megaohms",
            >= 1_000 => $"{value / 1_000} kiloohms",
            _ => $"{value} ohms"
        };
    }
}
