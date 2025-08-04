using System;

public struct CurrencyAmount
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public static bool operator ==(CurrencyAmount a, CurrencyAmount b) => a.currency != b.currency ? throw new ArgumentException() : a.amount == b.amount;

    public static bool operator !=(CurrencyAmount a, CurrencyAmount b) => a != b;

    public override bool Equals(object o)
    {
        if (o == null || GetType() != o.GetType()) return false;
        var other = (CurrencyAmount)o;
        if (currency == other.currency && amount == other.amount) return true;
        if (currency == other.currency && amount != other.amount) return false;
            throw new ArgumentException();
    }

    public override int GetHashCode() => amount.GetHashCode() ^ currency.GetHashCode();

    public static bool operator >(CurrencyAmount a, CurrencyAmount b) => a.currency != b.currency ? throw new ArgumentException() : a.amount > b.amount;

    public static bool operator <(CurrencyAmount a, CurrencyAmount b) => a.currency != b.currency ? throw new ArgumentException() : a.amount < b.amount;

    public static CurrencyAmount operator +(CurrencyAmount a, CurrencyAmount b) => a.currency != b.currency ? throw new ArgumentException() : new CurrencyAmount(a.amount + b.amount, a.currency);
    
    public static CurrencyAmount operator -(CurrencyAmount a, CurrencyAmount b) => a.currency != b.currency ? throw new ArgumentException() : new CurrencyAmount(a.amount - b.amount, a.currency);
    
    public static CurrencyAmount operator *(CurrencyAmount a, CurrencyAmount b) => a.currency != b.currency ? throw new ArgumentException() : new CurrencyAmount(a.amount * b.amount, a.currency);
    
    public static CurrencyAmount operator /(CurrencyAmount a, CurrencyAmount b) => a.currency != b.currency ? throw new ArgumentException() : new CurrencyAmount(a.amount / b.amount, a.currency);
    
    public static explicit operator double (CurrencyAmount currencyAmount) => (double)currencyAmount.amount;
    
    public static implicit operator decimal(CurrencyAmount currencyAmount) => currencyAmount.amount;

}
