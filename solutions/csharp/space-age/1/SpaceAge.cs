public class SpaceAge(double seconds)
{
    private const double EarthYearInSeconds = 31557600;
    public double OnEarth() => seconds / EarthYearInSeconds;

    public double OnMercury() => seconds / (EarthYearInSeconds * 0.2408467);

    public double OnVenus() => seconds / (EarthYearInSeconds * 0.61519726);

    public double OnMars() => seconds / (EarthYearInSeconds * 1.8808158);

    public double OnJupiter() => seconds / (EarthYearInSeconds * 11.862615);

    public double OnSaturn() => seconds / (EarthYearInSeconds * 29.447498);

    public double OnUranus() => seconds / (EarthYearInSeconds * 84.016846);

    public double OnNeptune() => seconds / (EarthYearInSeconds * 164.79132);
}