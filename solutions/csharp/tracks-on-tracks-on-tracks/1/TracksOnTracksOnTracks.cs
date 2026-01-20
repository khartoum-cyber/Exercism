public static class Languages
{
    public static List<string> NewList() => new();

    public static List<string> GetExistingLanguages() => new() {"C#", "Clojure", "Elm"};

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages) => languages.Count();

    public static bool HasLanguage(List<string> languages, string language) => languages.Any(l => l == language);

    public static List<string> ReverseList(List<string> languages) => Enumerable.Reverse(languages).ToList();

    public static bool IsExciting(List<string> languages) => languages.Count <= 3 && languages.Count != 0 && (languages[0] ==             "C#" || languages[1] == "C#");

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages = languages.Where(l => l != language).ToList();
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        var noduplicates = languages.Distinct().ToList();
        return languages.Count == noduplicates.Count;
    }
}
