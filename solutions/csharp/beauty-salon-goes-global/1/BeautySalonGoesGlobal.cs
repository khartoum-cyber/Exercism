using System.Globalization;

public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc) => dtUtc.ToLocalTime();

    public static DateTime Schedule(string appointmentDateDescription, Location location)
    {
        string timeZoneId = location switch
        {
            Location.NewYork => OperatingSystem.IsWindows()
                ? "Eastern Standard Time"
                : "America/New_York",
    
            Location.London => OperatingSystem.IsWindows()
                ? "GMT Standard Time"
                : "Europe/London",
    
            Location.Paris => OperatingSystem.IsWindows()
                ? "W. Europe Standard Time"
                : "Europe/Paris",
    
            _ => throw new ArgumentOutOfRangeException(
                nameof(location),
                location,
                "Unsupported salon location.")
        };
    
        DateTime localAppointment = DateTime.Parse(appointmentDateDescription);
    
        // The entered value represents wall-clock time at the salon,
        // not the local time of the computer running this code.
        localAppointment = DateTime.SpecifyKind(
            localAppointment,
            DateTimeKind.Unspecified);
    
        TimeZoneInfo salonTimeZone =
            TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
    
        return TimeZoneInfo.ConvertTimeToUtc(
            localAppointment,
            salonTimeZone);
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        return alertLevel switch
        {
                AlertLevel.Early => appointment.AddDays(-1),
                AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
                AlertLevel.Late => appointment.AddMinutes(-30),
                _ => throw new ArgumentOutOfRangeException("Unsupported alert level.")
        };
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        string timeZoneId = location switch
        {
            Location.NewYork => OperatingSystem.IsWindows()
                ? "Eastern Standard Time"
                : "America/New_York",
    
            Location.London => OperatingSystem.IsWindows()
                ? "GMT Standard Time"
                : "Europe/London",
    
            Location.Paris => OperatingSystem.IsWindows()
                ? "W. Europe Standard Time"
                : "Europe/Paris",
    
            _ => throw new ArgumentOutOfRangeException(nameof(location))
        };
    
        TimeZoneInfo tz = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
    
        return tz.IsDaylightSavingTime(dt) !=
               tz.IsDaylightSavingTime(dt.AddDays(-7));
    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo culture = location switch
        {
            Location.NewYork => new CultureInfo("en-US"),
            Location.London => new CultureInfo("en-GB"),
            Location.Paris => new CultureInfo("fr-FR"),
            _ => CultureInfo.InvariantCulture
        };
    
        if (DateTime.TryParse(dtStr, culture, DateTimeStyles.None, out DateTime dateValue))
        {
            return dateValue;
        }
    
        return DateTime.MinValue;
    }
}
