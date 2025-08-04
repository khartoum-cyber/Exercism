using System;
using System.Runtime.CompilerServices;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string value, string delimiter) => value.Split(delimiter)[1];

    public static string SubstringBetween(this string value, string delimiter1, string delimiter2) => value.Split(delimiter1)[1].Split(delimiter2)[0];

    public static string Message(this string value) => value.SubstringAfter(": ");

    public static string LogLevel(this string value) => value.SubstringBetween("[", "]");
}