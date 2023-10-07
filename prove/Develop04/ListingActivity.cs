class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts = new List<string>(){
            "Describe a moment today when you felt truly present and mindful.",
            "What are three things you can hear right now? Pay attention to the sounds around you.",
            "Close your eyes and take a deep breath. How does it feel to focus on your breath?",
            "Reflect on the taste, texture, and aroma of the last meal you enjoyed.",
            "Look around the room and name five different colors you see.",
            "Share one thing you're grateful for today and why it brings you joy.",
            "How does it feel to be in contact with nature? Share your experience.",
            "Describe a small act of kindness you witnessed or performed recently.",
            "Share a mindfulness exercise you practiced today and its impact on you.",
            "Reflect on a challenge you faced. How did you respond mindfully?",
            "Describe a moment when you felt a deep sense of calm or peace.",
            "How does it feel to engage in deep, intentional breathing for a minute?",
            "Share a quote or passage that inspires mindfulness and explain why.",
            "Describe the sensation of warmth or coolness on your skin right now.",
            "Share a mindfulness technique you use to stay present during daily tasks.",
            "Reflect on a recent interaction with someone. How did you practice active listening?",
            "How can you incorporate mindfulness into your daily routine?",
            "Describe the beauty in a natural object you observed today.",
            "Share a moment when you let go of worry and embraced the present moment.",
            "Reflect on a mindfulness practice that brings you a sense of inner peace."
        };
    public ListingActivity(string name = "Listing", string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") : base(name, description){
        
    }
    public void Run(){
        DisplayStartingMessage();

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        DisplayPrompt();
        Console.Write("You may begin in: ");
        ShowCountdown(5);

        Console.WriteLine();

       _count = GetListFromUser().Count;

        Console.WriteLine($"You listed {_count} items\r\n");

        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public string GetRandomPrompt(){
        Random rand = new Random();
        return _prompts[rand.Next(0, _prompts.Count())];
    }
    public void DisplayPrompt(){
        Console.WriteLine("List as many responses you can to the following prompt:\r\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\r\n");
    }
    public List<string> GetListFromUser(){
        List<string> userList = new List<string>();
        
        DateTime currentTime = DateTime.Now;
        DateTime finishTime = currentTime.AddSeconds(_duration);

        while(DateTime.Now < finishTime){
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }
        return userList;
    }

    public void AddPrompt(string prompt){
        _prompts.Add(prompt);
    }
}