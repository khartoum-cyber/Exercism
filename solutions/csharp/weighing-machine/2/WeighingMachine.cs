using System;
using System.Globalization;

class WeighingMachine
{
    // Get-only property set by constructor
    public int Precision { get; }

    public WeighingMachine(int precision)
    {
        if (precision < 0)
            throw new ArgumentOutOfRangeException(nameof(precision), "Precision cannot be negative.");

        Precision = precision;
    }

    // Backing field for Weight to allow validation
    private double _weight;

    // The current measured weight (must be non-negative)
    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(nameof(Weight), "Weight cannot be negative.");
            _weight = value;
        }
    }

    // Tare adjustment (defaults to 5)
    public double TareAdjustment { get; set; } = 5;

    // Displayed weight: (Weight - TareAdjustment) with "kg"
    public string DisplayWeight
    {
        get
        {
            var net = Weight - TareAdjustment;
            var rounded = Math.Round(net, Precision, MidpointRounding.AwayFromZero);
            return string.Format(CultureInfo.InvariantCulture, "{0:F" + Precision + "} kg", rounded);
        }
    }
}
