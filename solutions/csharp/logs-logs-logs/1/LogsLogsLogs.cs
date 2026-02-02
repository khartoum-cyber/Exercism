// TODO: define the 'LogLevel' enum
enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine) => logLine.Substring(1,3) switch
    {
        "TRC" => LogLevel.Trace,
        "DBG" => LogLevel.Debug,
        "INF" => LogLevel.Info,
        "WRN" => LogLevel.Warning,
        "ERR" => LogLevel.Error,
        "FTL" => LogLevel.Fatal,
        _     => LogLevel.Unknown
    };

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        int shortCode = logLevel switch
        {
            LogLevel.Trace   => 1,
            LogLevel.Debug   => 2,
            LogLevel.Info    => 4,
            LogLevel.Warning => 5,
            LogLevel.Error   => 6,
            LogLevel.Fatal   => 42,
            _ => 0
        };

        return $"{shortCode}:{message}";
    }
}
