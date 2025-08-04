using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch
    {
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new ArgumentOutOfRangeException()
    };

    public static string AnalyzeOffField(object report) => report switch
    {
        string => report.ToString(),
        int => $"There are {report} supporters at the match.",
        Foul => "The referee deemed a foul.",
        Injury and Incident i => $"Oh no! {i.GetDescription()} Medics are on the field.",
        Incident => "An incident happened.",
        Manager { Club: null} m => $"{m.Name}",
        Manager m => $"{m.Name} ({m.Club})",
        _ => throw new ArgumentException()
    };
}
