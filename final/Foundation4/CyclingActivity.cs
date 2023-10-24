class CyclingActivity : Activity {
    private double _speed;
    public CyclingActivity(DateOnly date, double lengthInMinutes, double speed) : base(date, lengthInMinutes){
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes}min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
    public override double GetDistance()
    {
        return Math.Round(_minutes / GetPace(), 2);
    }
    public override double GetSpeed()
    {
        return Math.Round(_speed, 2);
    }
    public override double GetPace()
    {
        return Math.Round(60 / _speed, 2);
    }
}