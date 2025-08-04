using System;

public enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine) => logLine.Substring(1, 3) switch
    {
        "TRC" => LogLevel.Trace,
        "DBG" => LogLevel.Debug,
        "INF" => LogLevel.Info,
        "WRN" => LogLevel.Warning,
        "ERR" => LogLevel.Error,
        "FTL" => LogLevel.Fatal,
        _ => LogLevel.Unknown
    };

    public static string OutputForShortLog(LogLevel logLevel, string message) => logLevel switch
    {
        LogLevel.Trace => $"{LogLevel.Trace.GetHashCode()}:{message}",
        LogLevel.Debug => $"{LogLevel.Debug.GetHashCode()}:{message}",
        LogLevel.Info => $"{LogLevel.Info.GetHashCode()}:{message}",
        LogLevel.Warning => $"{LogLevel.Warning.GetHashCode()}:{message}",
        LogLevel.Error => $"{LogLevel.Error.GetHashCode()}:{message}",
        LogLevel.Fatal => $"{LogLevel.Fatal.GetHashCode()}:{message}",
        _ => $"{LogLevel.Unknown.GetHashCode()}:{message}"
    };
}
