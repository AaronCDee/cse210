using System.IO;

public class Journal {
    public List<Entry> _entries = new List<Entry>();
    public string _name;
    public Journal() {}

    public void DisplayAll(){
        Console.WriteLine("Journal Entries:");
        foreach(Entry entry in _entries){
            Console.WriteLine("-----------------------------------");
            entry.Display();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\n");
        }
    }

    public void AddEntry(Entry newEntry) {
        _entries.Add(newEntry);
    }

    /*
        Entries will be saved in the following format:
        date,promptText,entryText
    */
    public void SaveToFile(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            outputFile.WriteLine("date,promptText,entryText");
            foreach(Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
        
    }
    public void LoadFromFile(string fileName){
        if(!File.Exists(fileName)){
            Console.WriteLine("File doesn't exist");
            return;
        }

        List<Entry> tempEntries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        int row = 0; 
        foreach (string line in lines)
        {
            if(row == 0){
                // Skip the header
                row++;
                continue;
            }
            string[] entryParts = line.Split(",");

            string date = entryParts[0];
            string promptText = entryParts[1];
            string entryText = entryParts[2];

            Entry loadedEntry = new Entry();
                loadedEntry._date = date;
                loadedEntry._entryText = entryText;
                loadedEntry._promptText = promptText;

            tempEntries.Add(loadedEntry);

            row++;
        }

        _entries = tempEntries;
    }
}