using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly Dictionary<string, int> _roster = [];

    public bool Add(string student, int grade) => _roster.TryAdd(student, grade);

    public IEnumerable<string> Roster() => _roster.OrderBy(i => i.Value).ThenBy(i => i.Key).Select(i => i.Key);

    public IEnumerable<string> Grade(int grade) =>
        _roster.Where(i => i.Value == grade).OrderBy(i => i.Key).Select(i => i.Key);
}