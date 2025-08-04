static class Badge
{
    public static string Print(int? id, string name, string? department) => id switch
    {
        null => $"{name} - {department?.ToUpper() ?? "OWNER"}",
        _ => $"[{id}] - {name} - {department?.ToUpper() ?? "OWNER"}"
    };
}