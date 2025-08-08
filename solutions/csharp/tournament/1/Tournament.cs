public static class Tournament
{   
    private static readonly Dictionary<string, TeamStats> teamStats = new();

    public static void Tally(Stream inStream, Stream outStream)
    {
        if (inStream == null)
            throw new ArgumentNullException(nameof(inStream));
        if (outStream == null) 
            throw new ArgumentNullException(nameof(outStream));

        teamStats.Clear();

        var reader = new StreamReader(inStream);
        var writer = new StreamWriter(outStream);
        string content = reader.ReadToEnd();
        string[] lines = content.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var line in lines)
        {
            string[] splitLine = line.Split(';');
            if (splitLine.Length != 3)
            {
                writer.WriteLine($"Invalid line format: {line}");
                continue;
            }

            string team1 = splitLine[0];
            string team2 = splitLine[1];
            string result = splitLine[2].ToLower();

            ProcessMatch(team1, team2, result);
        }

        // Output table
        writer.Write("Team                           | MP |  W |  D |  L |  P");
        foreach (var entry in teamStats.OrderByDescending(e => e.Value.P).ThenBy(e => e.Key))
        {
            string team = entry.Key;
            TeamStats stats = entry.Value;
            writer.Write('\n');
            writer.Write($"{team,-30} | {stats.MP,2} | {stats.W,2} | {stats.D,2} | {stats.L,2} | {stats.P,2}");
        }

        writer.Flush();
    }

    private static void ProcessMatch(string team1, string team2, string result)
    {
        teamStats.TryAdd(team1, new TeamStats());
        teamStats.TryAdd(team2, new TeamStats());

        switch (result)
        {
            case "win":
                teamStats[team1].RecordWin();
                teamStats[team2].RecordLoss();
                break;
            case "loss":
                teamStats[team1].RecordLoss();
                teamStats[team2].RecordWin();
                break;
            case "draw":
                teamStats[team1].RecordDraw();
                teamStats[team2].RecordDraw();
                break;
        }
    }

    private class TeamStats
    {
        public int MP { get; set; } = 0;
        public int W { get; set; } = 0;
        public int D { get; set; } = 0;
        public int L { get; set; } = 0;
        public int P { get; set; } = 0;

        public void RecordWin()
        {
            MP++; W++; P += 3;
        }

        public void RecordLoss()
        {
            MP++; L++;
        }

        public void RecordDraw()
        {
            MP++; D++; P += 1;
        }
    }
}