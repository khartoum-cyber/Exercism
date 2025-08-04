using System;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => DateTime.Parse(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => new TimeSpan(11, 59, 59) < appointmentDate.TimeOfDay && new TimeSpan(18, 0, 0) > appointmentDate.TimeOfDay;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";

    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15, 0, 0, 0);
}
