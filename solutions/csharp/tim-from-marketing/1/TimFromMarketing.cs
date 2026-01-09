static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        
        var deptLabel = department is null ? "OWNER" : department.ToUpperInvariant();

        return id is null
            ? $"{name} - {deptLabel}"
            : $"[{id}] - {name} - {deptLabel}";

    }
}
