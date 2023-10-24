class RunningActivity : Activity {
    private double _distance;
    public RunningActivity(DateOnly date, double lengthInMinutes, double distance) : base(date, lengthInMinutes){
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{_date} Running ({_minutes} min) - Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
   public override double GetDistance()
    {
        return Math.Round(_distance, 2);
    }
    public override double GetSpeed()
    {
        return Math.Round((GetDistance() / _minutes) * 60, 2);
    }
    public override double GetPace()
    {
        return Math.Round(_minutes / GetDistance(), 2);
    }
}