using System;
using System.Collections.Generic;
using System.Linq;

public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
    public double DistanceBetweenCoordsSquared(Coord other) =>
        Math.Pow(X - other.X, 2) +
        Math.Pow(Y - other.Y, 2);
}

public struct Plot(Coord coord1, Coord coord2, Coord coord3, Coord coord4)
{
    public Coord Coord1 { get; } = coord1;
    public Coord Coord2 { get; } = coord2;
    public Coord Coord3 { get; } = coord3;
    public Coord Coord4 { get; } = coord4;
    public readonly double LongestSideSquared { get => CalculateLongestSideSquared(coord1, coord2, coord3, coord4); }

    private static double CalculateLongestSideSquared(Coord coord1, Coord coord2, Coord coord3, Coord coord4)
    {
        var _sides = new double[4];
        _sides[0] = coord1.DistanceBetweenCoordsSquared(coord2);
        _sides[1] = coord2.DistanceBetweenCoordsSquared(coord3);
        _sides[2] = coord3.DistanceBetweenCoordsSquared(coord4);
        _sides[3] = coord4.DistanceBetweenCoordsSquared(coord1);
        return _sides.Max();
    }
}


public class ClaimsHandler
{
    private List<Plot> plots = [];

    public void StakeClaim(Plot plot) => plots.Add(plot);

    public bool IsClaimStaked(Plot plot) => plots.Contains(plot);

    public bool IsLastClaim(Plot plot) => plot.Equals(plots.Last());

    public Plot GetClaimWithLongestSide() => plots.MaxBy(p => p.LongestSideSquared);
}
