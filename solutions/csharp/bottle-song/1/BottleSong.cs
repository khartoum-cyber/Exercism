using System.Collections.Generic;

public static class BottleSong
{
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        string[] numbers = { "No", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten" };
        var song = new List<string>();
        int remainingVerses = takeDown;
        int remainingBottles = startBottles;

        while (remainingVerses > 0)
        {
            song.Add($"{numbers[remainingBottles]} green {(remainingBottles > 1 ? "bottles" : "bottle")} hanging on the wall,");
            song.Add($"{numbers[remainingBottles]} green {(remainingBottles > 1 ? "bottles" : "bottle")} hanging on the wall,");
            song.Add("And if one green bottle should accidentally fall,");
            remainingBottles--;

            song.Add($"There'll be {numbers[remainingBottles].ToLower()} green {(remainingBottles == 1 ? "bottle" : "bottles")} hanging on the wall.");
            remainingVerses--;

            if (remainingVerses > 0)
            {
                song.Add("");
            }
        }

        return song;
    }
}