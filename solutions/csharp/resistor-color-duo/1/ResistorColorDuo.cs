using System;
using System.Text;

public static class ResistorColorDuo
{
    private static readonly StringBuilder sb = new();
    private enum Colors
    {
        Black,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Violet,
        Grey,
        White,
    }
    public static int Value(string[] colors) => Value(colors[0]) * 10 + Value(colors[1]);

    private static int Value(string color) => (int)Enum.Parse<Colors>(color, ignoreCase: true);
}
