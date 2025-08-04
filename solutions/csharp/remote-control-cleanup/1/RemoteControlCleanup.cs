public class RemoteControlCar
{
    public string CurrentSponsor { get; private set; }

    private Speed _currentSpeed;

    public CarTelemetry Telemetry;

    public RemoteControlCar() => Telemetry = new CarTelemetry(this);

    public string GetSpeed() => _currentSpeed.ToString();

    private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;

    private void SetSpeed(Speed speed) => _currentSpeed = speed;

    public class CarTelemetry(RemoteControlCar parent)
    {
        public static void Calibrate() {}

        public static bool SelfTest() => true;
    
        public void ShowSponsor(string sponsorName) => parent.SetSponsor(sponsorName);
    
        public void SetSpeed(decimal amount, string unitsString)
        {
            SpeedUnits speedUnits = (unitsString == "cps")
                ? SpeedUnits.CentimetersPerSecond
                : SpeedUnits.MetersPerSecond;

            parent.SetSpeed(new Speed(amount, speedUnits));
        }
    }

    public enum SpeedUnits
    {
        MetersPerSecond,
        CentimetersPerSecond
    }
    
    public readonly struct Speed(decimal amount, SpeedUnits speedUnits)
    {
        public decimal Amount { get; } = amount;
        public SpeedUnits SpeedUnits { get; } = speedUnits;
    
        public override string ToString() => SpeedUnits == SpeedUnits.CentimetersPerSecond
            ? $"{Amount} centimeters per second"
            : $"{Amount} meters per second";
    }
}