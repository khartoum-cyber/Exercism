using System;

public class RemoteControlCar
{
    private int batteryPercentage = 100;
    private int distanceDrivenInMeters = 0;
    private string[] sponsors = [];
    private int latestSerialNum = 0;

    public void Drive()
    {
        if (batteryPercentage > 0)
        {
            batteryPercentage -= 10;
            distanceDrivenInMeters += 2;
        }
    }

    public void SetSponsors(params string[] sponsors) => this.sponsors = sponsors;

    public string DisplaySponsor(int sponsorNum) => sponsors[sponsorNum];

    public bool GetTelemetryData(ref int serialNum,
        out int batteryPercentage, out int distanceDrivenInMeters)
    {
        if (serialNum > latestSerialNum)
        {
            latestSerialNum = serialNum;
            batteryPercentage = this.batteryPercentage;
            distanceDrivenInMeters = this.distanceDrivenInMeters;
            return true;
        }

        serialNum = latestSerialNum;
        batteryPercentage = -1;
        distanceDrivenInMeters = -1;
        return false;
    }

    public static RemoteControlCar Buy() => new();
}

public class TelemetryClient(RemoteControlCar car)
{
    private RemoteControlCar car = car;

    public string GetBatteryUsagePerMeter(int serialNum) => car.GetTelemetryData(ref serialNum, out var battery, out var distance) && distance > 0
        ? $"usage-per-meter={(100 - battery) / distance}" 
        : "no data";
}
