using System;

static class AssemblyLine
{
    private const int CarsPerHour = 221;
    
    private const int MinutesInAnHour = 60;

    public static double SuccessRate(int speed) => speed switch
    {
        0 => 0.0,
        >= 1 and <= 4 => 1.0,
        <= 8 => 0.9,
        9 => 0.8,
        _ => 0.77
    };

    public static double ProductionRatePerHour(int speed) => Convert.ToDouble(speed * CarsPerHour * SuccessRate(speed));

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / MinutesInAnHour);
}