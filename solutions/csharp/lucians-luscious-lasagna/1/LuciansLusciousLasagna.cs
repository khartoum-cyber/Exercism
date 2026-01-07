class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int minsInOven) => ExpectedMinutesInOven() - minsInOven;

    public int PreparationTimeInMinutes(int layers) => layers * 2;

    public int ElapsedTimeInMinutes(int layers, int minsInOven) => minsInOven + PreparationTimeInMinutes(layers);
}
