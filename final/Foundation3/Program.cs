using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Street 1", "City 1", "State 1", "Country 1");
        Lecture lecture = new Lecture("Bill Nye the science guy", "He teaches science", new DateOnly(2023, 11, 3), new TimeOnly(15, 0, 0), address1, "Bill Nye", 30);

        Address address2 = new Address("Street 2", "City 2", "State 2", "Country 2");
        OutdoorGathering outGather = new OutdoorGathering("Picnic in the Park", "Some music and food", new DateOnly(2023, 12, 3), new TimeOnly(12, 0, 0), address2, "Cloudy with a chance of meatballs");

        Address address3 = new Address("Street 3", "City 3", "State 3", "Country 3");
        Reception reception = new Reception("Travis Barker & Kourtney Kardashian", "It's their wedding #Blink182", new DateOnly(2024, 1, 31), new TimeOnly(16, 0, 0), address3, "blink182@punk.com");

        Console.WriteLine(lecture.GetTypeStr());
        Console.WriteLine("--------------------------");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Full Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("--------------------------");
       
        Console.WriteLine();
        
        Console.WriteLine(outGather.GetTypeStr());
        Console.WriteLine("--------------------------");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(outGather.GetStandardDetails());
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Full Details:");
        Console.WriteLine(outGather.GetFullDetails());
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Short Description:");
        Console.WriteLine(outGather.GetShortDescription());
        Console.WriteLine("--------------------------");
        
        Console.WriteLine();

        Console.WriteLine(reception.GetTypeStr());
        Console.WriteLine("--------------------------");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Full Details:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("--------------------------");
        Console.WriteLine();
        Console.WriteLine("--------------------------");
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("--------------------------");
    }
}