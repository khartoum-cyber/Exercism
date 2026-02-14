public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        long result = 0;
        
        try
        {
            checked
            {
                result = @base * multiplier;
            }
        }
        catch (OverflowException e)
        {
            return "*** Too Big ***";
        }

        return result.ToString();
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        float result = @base * multiplier;

        if(float.IsInfinity(result) || float.IsNaN(result))
            return "*** Too Big ***";

        return result.ToString();
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        decimal result = 0;
        
        try
        {
            result = salaryBase * multiplier;
        }
        catch(OverflowException ex)
        {
            return "*** Much Too Big ***";
        }

        return result.ToString();
    }
}
