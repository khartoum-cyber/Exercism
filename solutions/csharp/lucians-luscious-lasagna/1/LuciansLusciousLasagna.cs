class Lasagna
{
    public const int layerPrepareTime = 2;
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minutesInOven) => ExpectedMinutesInOven() - minutesInOven;

    public int PreparationTimeInMinutes(int layers) => layers * layerPrepareTime;

    public int ElapsedTimeInMinutes(int layers, int minutesInTheOven) => PreparationTimeInMinutes(layers) + minutesInTheOven;
}
