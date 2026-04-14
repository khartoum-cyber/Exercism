public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }
}

public struct Plot
{
    public Coord A { get; }
    public Coord B { get; }
    public Coord C { get; }
    public Coord D { get; }

    public Plot(Coord a, Coord b, Coord c, Coord d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }
    
    private static double Distance(Coord p1, Coord p2)
    {
        int dx = p1.X - p2.X;
        int dy = p1.Y - p2.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public double LongestSide()
    {
        return Math.Max(
            Math.Max(Distance(A, B), Distance(B, C)),
            Math.Max(Distance(C, D), Distance(D, A))
        );
    }
}


public class ClaimsHandler
{
    private readonly List<Plot> claims = new();
    
    public void StakeClaim(Plot plot) => claims.Add(plot);

    public bool IsClaimStaked(Plot plot) => claims.Contains(plot);

    public bool IsLastClaim(Plot plot) => claims.Count > 0 && claims[^1].Equals(plot);

    public Plot GetClaimWithLongestSide()
    {
        return claims
            .OrderByDescending(p => p.LongestSide())
            .First();
    }
}
