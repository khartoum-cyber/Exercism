using System.Collections.Generic;
using System.Linq;

public class HighScores(List<int> _list)
{
    public List<int> Scores() => _list;

    public int Latest() => _list[^1];

    public int PersonalBest() => _list.Max();

    public List<int> PersonalTopThree() => _list.OrderByDescending(x => x).Take(3).ToList();
}