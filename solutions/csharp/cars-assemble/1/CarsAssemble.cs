static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed switch
    {
        10 => 0.77,
        9 => 0.8,
        >= 5 and <= 8 => 0.9,
        >= 1 and <= 4 => 1.0,
        _ => 0
    };
    
    public static double ProductionRatePerHour(int speed) => speed * 221 * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)ProductionRatePerHour(speed) / 60;
}
