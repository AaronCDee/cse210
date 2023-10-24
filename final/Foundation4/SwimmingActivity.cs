class SwimmingActivity : Activity {
    private double _laps;
    public SwimmingActivity(DateOnly date, double lengthInMinutes, double laps) : base(date, lengthInMinutes){
        _laps = laps;
    }

    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes}min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
    public override double GetDistance()
    {
        return Math.Round(_laps * 50 / 1000, 2);
    }
    public override double GetSpeed()
    {
        return Math.Round(60 / GetPace(), 2);
    }
    public override double GetPace()
    {
        return Math.Round(_minutes / GetDistance(), 2);
    }
}