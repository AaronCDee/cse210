class Activity {
    protected DateOnly _date;
    protected double _minutes;
    public Activity(DateOnly date, double lengthInMinutes){
        _date = date;
        _minutes = lengthInMinutes;
    }

    public virtual string GetSummary(){
        return "";
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    

}