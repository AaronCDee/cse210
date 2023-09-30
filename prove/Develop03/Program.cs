using System;

class Program
{   
    static void Main(string[] args)
    {
        Library lib = new Library();

        string book1 = "1 Nephi";
        int chapter1 = 2;
        int verse1 = 15;
        // int endVerse1 = 16;
        string scriptureText1 = "And my father dwelt in a tent";

        Reference scriptureRef1 = new Reference(book1, chapter1, verse1);
        Scripture scripture1 = new Scripture(scriptureRef1, scriptureText1);

        lib.AddScripture(scripture1);

        string book2 = "3 Nephi";
        int chapter2 = 17;
        int verse2 = 22;
        int endVerse2 = 23;
        string scriptureText2 = "And when he had done this he wept again; And he spake unto the multitude, and said unto them: Behold your little ones.";

        Reference scriptureRef2 = new Reference(book2, chapter2, verse2, endVerse2);
        Scripture scripture2 = new Scripture(scriptureRef2, scriptureText2);

        lib.AddScripture(scripture2);

        bool scriptureSelected = false;
        Scripture scripture = lib.SelectScripture();

        Console.Clear();
        Console.WriteLine("Please select a scripture to memorize:");
        Console.Write(lib.GetMenuText());
        Console.WriteLine("Enter 'random' for a random scripture");
        Console.WriteLine("Enter 'quit' to exit");

        while(!scriptureSelected){
            string selectIn = Console.ReadLine();
            
            if(selectIn.ToLower() == "quit"){
                Environment.Exit(1);
            }

            if(selectIn.ToLower() == "random"){
                break;
            }

            try
            {
                scripture = lib.SelectScripture(int.Parse(selectIn), false);
                scriptureSelected = true;
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        

        string input = "run";

        while(input.ToLower() != "quit" && !scripture.IsCompletelyHidden()){
            if(input == ""){
                scripture.HideRandomWords(1);
            }
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to hide words or type 'quit'");
            if(!scripture.IsCompletelyHidden()){
                input = Console.ReadLine();
            }
        }
    }
}