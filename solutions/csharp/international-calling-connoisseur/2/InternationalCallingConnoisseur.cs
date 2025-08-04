using System.Collections.Generic;
using System.Linq;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary() => new Dictionary<int, string>();

    public static Dictionary<int, string> GetExistingDictionary()
    {
        var dialCodes = new Dictionary<int, string>()
        {
            { 1, "United States of America" },
            { 55, "Brazil" },
            { 91, "India" }
        };
        return dialCodes;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var newDict = new Dictionary<int, string>
        {
            { countryCode, countryName }
        };
        return newDict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName) => existingDictionary.Append(new KeyValuePair<int, string>(countryCode, countryName)).ToDictionary();

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.GetValueOrDefault(countryCode) ?? "";

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.ContainsKey(countryCode);

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName) => existingDictionary.Select(d => d.Key == countryCode ? new KeyValuePair<int, string>(countryCode, countryName) : d).ToDictionary();

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode) => existingDictionary.Where(d => d.Key != countryCode).ToDictionary();

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary) =>
        existingDictionary.Values.MaxBy(d => d.Length) ?? "";
}