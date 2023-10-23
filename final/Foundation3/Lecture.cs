class Lecture : Event {
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, string speakerName, int capacity) : base(title, description, date, time, address){
        _speakerName = speakerName;
        _capacity = capacity;
        SetType("Lecture");
    }

    public string GetFullDetails(){
        return GetStandardDetails() + $"\r\nSpeaker: {_speakerName}\r\nCapacity: {_capacity}";
    }
}