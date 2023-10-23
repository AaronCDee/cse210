class OutdoorGathering : Event {
    private string _weatherStatement;
    public OutdoorGathering(string title, string description, DateOnly date, TimeOnly time, Address address, string weatherStatement) : base(title, description, date, time, address){
        _weatherStatement = weatherStatement;
        SetType("Outdoor Gathering");
    }

    public string GetFullDetails(){
        return GetStandardDetails() + $"\r\nWeather: {_weatherStatement}";
    }
}