using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("2 Blue Street", "Johannesburg", "Gauteng", "SA");
        Customer customer1 = new Customer("Aaron", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Juice", "1", 2.50, 3));
        order1.AddProduct(new Product("Milk", "2", 3, 4));
        order1.AddProduct(new Product("Eggs", "3", 5, 2));
        Console.WriteLine("/********************/");
        Console.WriteLine("Order 1");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order total: ${order1.CalculateTotalCost()}");
        Console.WriteLine("/********************/");
        Console.WriteLine();

        Address address2 = new Address("3 Green Street", "San Diego", "California", "USA");
        Customer customer2 = new Customer("Baron", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Lego", "4", 800, 1));
        order2.AddProduct(new Product("GPU", "5", 1500, 1));
        order2.AddProduct(new Product("Motherboard", "6", 500, 1));
        order2.AddProduct(new Product("CPu", "7", 1000, 1));
        Console.WriteLine("/********************/");
        Console.WriteLine("Order 2");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order total: ${order2.CalculateTotalCost()}");
        Console.WriteLine("/********************/");
    }
}