using System;

class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    private int _distance;
    private int _battery;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        _distance = 0;
        _battery = 100;
    }

    public bool BatteryDrained() => _battery >= batteryDrain ? false : true;

    public int DistanceDriven() => _distance;

    public void Drive()
    {
        if (!BatteryDrained()) 
        {
            _distance += speed;
            _battery -= batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;
    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car) => (100/car.batteryDrain * car.speed) >= _distance;
}
