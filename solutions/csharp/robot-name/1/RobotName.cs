using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly Random Rng = new();

    private static readonly HashSet<string> RobotTracker = [];

    public string Name { get; private set; }

    public Robot() => Reset();

    public void Reset() => Name = GetUniqueName();

    private string GetUniqueName()
    {
        var robotName = GenerateRobotName();
        while (!RobotTracker.Add(robotName))
        {
            robotName = GenerateRobotName();
        }
        return robotName;
    }

    private string GenerateRobotName()
    {
        var result = new char[5];

        for (int i = 0; i < 2; i++)
        {
            result[i] = (char)Rng.Next('A', 'Z' + i);
        }

        for (int i = 2; i < 5; i++)
        {
            result[i] = (char)Rng.Next('0', '9' + 1);
        }

        return new string(result);
    }
}