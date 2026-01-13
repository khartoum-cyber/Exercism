class RemoteControlCar
{
    private int _metersDriven = 0;
    private int _batteryLeft = 100;
    
    public int Speed { get; }
    public int BatteryDrain { get; }
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _batteryLeft <= 0 || _batteryLeft < BatteryDrain;

    public int DistanceDriven() => _metersDriven;

    public void Drive()
    {
        if(!BatteryDrained())
        {
            _metersDriven += Speed;
            _batteryLeft -= BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        RemoteControlCar nitroCar = new RemoteControlCar(50,4);
        return nitroCar;
    }
}

class RaceTrack
{
    private int _distance;
    
    public RaceTrack(int distance) => _distance = distance;

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(!car.BatteryDrained())
            car.Drive();
        
        return car.DistanceDriven() >= _distance ? true : false;
    }
}
