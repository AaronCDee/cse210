using System;

class Program
{
    static void Main(string[] args)
    {

        string input = "";
        while(input != "4"){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start Breathing Activity");
            Console.WriteLine("\t2. Start Reflecting Activity");
            Console.WriteLine("\t3. Start Listing Activity");
            Console.WriteLine("\t4. Quit");
            Console.WriteLine("Select a choice from the menu");
            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                break;
                
                case "2":
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                break;

                case "3":
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                break;

                case "4":
                break;

                default:
                 Console.WriteLine("Option not supported, please try again...");
                break;
            }
        }
    }
}