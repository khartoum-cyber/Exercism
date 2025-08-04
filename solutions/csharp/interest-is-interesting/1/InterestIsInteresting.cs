using System;
using Microsoft.VisualBasic;

static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance switch
    {
        >= 0 and < 1000m => 0.5f,
        >= 1000m and < 5000m => 1.621f,
        >= 5000m => 2.475f,
        _ => 3.213f
    };

    public static decimal Interest(decimal balance) => balance * (decimal)InterestRate(balance) / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) => balance + Interest(balance);

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        do
        {
            balance += Interest(balance);
            years++;
        } while (balance <= targetBalance);

        return years;
    }
}
