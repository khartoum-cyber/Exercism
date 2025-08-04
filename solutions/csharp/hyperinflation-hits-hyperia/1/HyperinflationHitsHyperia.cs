using System;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            checked
            {
                return (@base * multiplier).ToString();
            }
        }
        catch (OverflowException e)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        var gdp = @base * multiplier;

        return !float.IsPositiveInfinity(gdp) ? gdp.ToString() : "*** Too Big ***";
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        { 
            return (salaryBase * multiplier).ToString();
        }
        catch (OverflowException e)
        {
            return "*** Much Too Big ***";
        }
    }
}
