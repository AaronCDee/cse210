class Customer{
    private string _name;
    private Address _address;
    
    public Customer(string name, Address address){
        _name = name;
        _address = address;
    }

    public void SetAddress(Address address){
        _address = address;
    }

    public bool IsInUsa(){
        return _address.IsInUsa();
    }

    public string GetName(){
        return _name;
    }

    public string GetAddress(){
        return _address.GetAddressText();
    }

}