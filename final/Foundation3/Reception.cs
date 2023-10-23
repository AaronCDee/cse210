class Reception : Event {
    private string _rsvpEmail;
    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string rsvpEmail) : base(title, description, date, time, address){
        _rsvpEmail = rsvpEmail;
        SetType("Reception");
    }

    public string GetFullDetails(){
        return GetStandardDetails() + $"\r\nRSVP: {_rsvpEmail}";
    }
}