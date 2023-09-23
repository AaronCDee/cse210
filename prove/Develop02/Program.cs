using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string input = "-1";

        while(input != "0"){
            Console.WriteLine("Welcome to your Journal program");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("0. Quit");
            Console.WriteLine("What would you like to do?");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string myPrompt = promptGenerator.GeneratePrompt();
                    
                    Console.WriteLine(myPrompt);
                    
                    string myEntryText = Console.ReadLine();
                    
                    Entry myEntry = new Entry();
                        myEntry._promptText = myPrompt;
                        myEntry._entryText = myEntryText;
                        myEntry._date = DateTime.Now.ToShortDateString();
                    myJournal.AddEntry(myEntry);
                    break;

                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Please insert a file name:");
                    string loadingFileName = Console.ReadLine();
                    myJournal.LoadFromFile(loadingFileName);
                    break;
                case "4":
                    Console.WriteLine("Please insert a file name:");
                    string writingFileName = Console.ReadLine();
                    myJournal.SaveToFile(writingFileName);
                    Console.WriteLine("File saved successfully");
                    break;
                default:
                    Console.WriteLine("Choice not supported, please select a valid choice");
                    break;
            }
        }
    }
}