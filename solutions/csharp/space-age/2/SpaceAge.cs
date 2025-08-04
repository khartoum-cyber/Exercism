using System.Collections.Generic;

enum Planet
{
    Mercury,
    Venus,
    Earth,
    Mars,
    Jupiter,
    Saturn,
    Uranus,
    Neptune
}
public class SpaceAge(double seconds)
{
    private readonly Dictionary<Planet, double> _orbitalPeriods = new()
    {
        {Planet.Mercury, 0.2408467},
        {Planet.Venus, 0.61519726},
        {Planet.Earth, 1.0},
        {Planet.Mars, 1.8808158},
        {Planet.Jupiter, 11.862615},
        {Planet.Saturn, 29.447498},
        {Planet.Uranus, 84.016846},
        {Planet.Neptune, 164.79132}
    };

    private const double EarthYearInSeconds = 31557600;

    private double CalculateYears(Planet planet) => seconds / (EarthYearInSeconds * _orbitalPeriods[planet]);

    public double OnEarth() => CalculateYears(Planet.Earth);

    public double OnMercury() => CalculateYears(Planet.Mercury);

    public double OnVenus() => CalculateYears(Planet.Venus);

    public double OnMars() => CalculateYears(Planet.Mars);

    public double OnJupiter() => CalculateYears(Planet.Jupiter);

    public double OnSaturn() => CalculateYears(Planet.Saturn);

    public double OnUranus() => CalculateYears(Planet.Uranus);

    public double OnNeptune() => CalculateYears(Planet.Neptune);
}