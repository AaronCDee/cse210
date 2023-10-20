class Address {
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country){
        _country = country.ToUpper();
        _state = state;
        _city = city;
        _streetAddress = streetAddress;
    }

    public bool IsInUsa(){
        return _country == "USA";
    }

    public string GetAddressText(){
        string addressText = "Address\r\n";
        addressText += $"Street Address: {_streetAddress}\r\n";
        addressText += $"City: {_city}\r\n";
        addressText += $"State/Province: {_state}\r\n";
        addressText += $"Country: {_country}";
        
        return addressText;
    }

}