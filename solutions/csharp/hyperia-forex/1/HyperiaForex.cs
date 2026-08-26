public struct CurrencyAmount : IEquatable<CurrencyAmount>
{
    private decimal amount;
    private string currency;

    public CurrencyAmount(decimal amount, string currency)
    {
        this.amount = amount;
        this.currency = currency;
    }

    public bool Equals(CurrencyAmount other)
    {
        return amount == other.amount && currency == other.currency;
    }
     
    public override bool Equals(object? obj)
    {
        return obj is CurrencyAmount other && Equals(other);
    }
     
    public override int GetHashCode()
    {
        return HashCode.Combine(amount, currency);
    }
    
    public static bool operator ==(CurrencyAmount left, CurrencyAmount right)
    {
        if(left.currency != right.currency)
            throw new ArgumentException();
        
        return left.Equals(right);
    }

    public static bool operator !=(CurrencyAmount left, CurrencyAmount right)
    {
        if(left.currency != right.currency)
            throw new ArgumentException();
        
        return !left.Equals(right);
    }

    public static bool operator >(CurrencyAmount left, CurrencyAmount right)
    {
        if(left.currency != right.currency)
            throw new ArgumentException();
        
        return left.amount > right.amount;
    }

    public static bool operator <(CurrencyAmount left, CurrencyAmount right)
    {
        if(left.currency != right.currency)
            throw new ArgumentException();
        
        return left.amount < right.amount;
    }

    public static CurrencyAmount operator +(CurrencyAmount left, CurrencyAmount right)
    {
        if(left.currency != right.currency)
        {
            throw new ArgumentException();
        }
        
        return new CurrencyAmount (left.amount + right.amount, left.currency);
    }

    public static CurrencyAmount operator -(CurrencyAmount left, CurrencyAmount right)
    {
        if(left.currency != right.currency)
        {
            throw new ArgumentException();
        }
        
        return new CurrencyAmount (left.amount - right.amount, left.currency);
    }

    public static CurrencyAmount operator *(CurrencyAmount left, decimal num)
    {
        return new CurrencyAmount (left.amount * num, left.currency);
    }

    public static CurrencyAmount operator *(decimal num, CurrencyAmount right)
    {
        return new CurrencyAmount (num * right.amount, right.currency);
    }

    public static CurrencyAmount operator /(CurrencyAmount left, decimal num)
    {
        return new CurrencyAmount (left.amount / num, left.currency);
    }

    public static CurrencyAmount operator /(decimal num, CurrencyAmount right)
    {
        return new CurrencyAmount (num / right.amount, right.currency);
    }

    public static explicit operator double(CurrencyAmount curr) => (double)curr.amount;

    public static implicit operator decimal(CurrencyAmount curr) => curr.amount;
    
}
