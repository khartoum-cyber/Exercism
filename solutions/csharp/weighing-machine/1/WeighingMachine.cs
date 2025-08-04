using System;

class WeighingMachine(int precision)
{
    public int Precision => precision;

    private double _weight;

    public double Weight
    {
        get => _weight;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _weight = value;
        }
    }

    public string DisplayWeight => $"{Math.Round(_weight - TareAdjustment, Precision).ToString($"n{Precision}")} kg";

    public double TareAdjustment { get; set; } = 5.0;
}
