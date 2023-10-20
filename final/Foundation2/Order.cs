class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }

    public double CalculateTotalCost(){
        double totalCost = 0;

        foreach (Product product in _products){
            totalCost += product.CalculateTotalCost();
        }

        double shipping = _customer.IsInUsa() ? 5 : 35;
        totalCost += shipping;

        return totalCost;
    }

    public string GetPackingLabel(){
        string packingLabel = "--------------\r\n";
        packingLabel += "Packing Label\r\n";

        List<string> productTexts = new List<string>();
        foreach (Product product in _products)
        {
            productTexts.Add(product.GetProductText());
        }

        packingLabel += string.Join("\r\n", productTexts);
        packingLabel += "\r\n--------------";

        return packingLabel;
    }

    public string GetShippingLabel(){
        string shippingLabel = "--------------\r\n";
        shippingLabel += "Shipping Label\r\n";
        shippingLabel += $"Customer: {_customer.GetName()}\r\n\r\n{_customer.GetAddress()}\r\n";
        shippingLabel +="--------------";
        return shippingLabel;
    }

    public void SetCustomer(Customer customer){
        _customer = customer;
    }

    public void AddProduct(Product product){
        _products.Add(product);
    }
}