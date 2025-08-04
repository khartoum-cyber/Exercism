public class Clock : IEquatable<Clock>
{
    private int _hours;
    private int _minutes;
    
    public Clock(int hours, int minutes)
    {
        int totalMinutes = (hours * 60) + minutes;
        _hours = ((totalMinutes / 60) % 24 + 24) % 24;
        _minutes = totalMinutes % 60;
        
       if (_minutes < 0)
        {
            _minutes += 60;
            _hours = (_hours - 1 + 24) % 24;
        }

    }

    public override string ToString()
    {
        return $"{_hours:D2}:{_minutes:D2}";
    }


    public Clock Add(int minutesToAdd)
    {
        int totalMinutes = _minutes + minutesToAdd;
        int newHours = (_hours + totalMinutes / 60) % 24;
        int newMinutes = totalMinutes % 60;
        
        return new Clock(newHours, newMinutes);
    }

    public Clock Subtract(int minutesToSubtract)
    {
        int totalMinutes = _minutes - minutesToSubtract;
        int newHours = (_hours + totalMinutes / 60) % 24;
        int newMinutes = totalMinutes % 60;
        
        if (newMinutes < 0)
        {
            newMinutes += 60;
            newHours = (newHours - 1 + 24) % 24;
        }
        
        return new Clock(newHours, newMinutes);
    }
    
    public bool Equals(Clock other)
    {
        if (other == null)
            return false;

        return _hours == other._hours && _minutes == other._minutes;
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        return Equals((Clock)obj);
    }

    public override int GetHashCode()
    {
        return (_hours, _minutes).GetHashCode();
    }

}
