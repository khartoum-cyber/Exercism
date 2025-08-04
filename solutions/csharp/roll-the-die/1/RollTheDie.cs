using System;

public class Player
{
    private readonly Random _randomNumber = new();
    public int RollDie() => _randomNumber.Next(1, 19);
    public double GenerateSpellStrength() => _randomNumber.NextDouble() * 100;
}