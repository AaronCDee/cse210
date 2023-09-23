public class Entry {
    public string _promptText;
    public string _entryText;
    public string _date; // Will change this to a date later maybe...

    
    public Entry() {}

    public void Display() {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine("Prompt:");
        Console.WriteLine(_promptText);
        Console.WriteLine("Entry:");
        Console.WriteLine(_entryText);
    }
}