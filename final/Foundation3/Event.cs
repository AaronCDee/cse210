using System.Net.Sockets;

class Event{
    protected string _type;
    protected string _title;
    protected string _description;
    protected DateOnly _date;
    protected TimeOnly _time;
    protected Address _address;

    public Event(string title, string description, DateOnly date, TimeOnly time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails(){
        return $"Title: {_title}\r\nDescription: {_description}\r\nDate: {_date}\r\nTime: {_time}\r\n{_address.GetAddressText()}";
    }

    public string GetShortDescription(){
        return $"Type of Event: {_type}\r\nTitle: {_title}\r\nDate: {_date}";
    }

    protected void SetType(string type){
        _type = type;
    }

    public string GetTypeStr(){
        return _type;
    }

}