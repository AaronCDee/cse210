using System.ComponentModel;

class BreathingActivity : Activity {
    private int _inTime = 4;
    private int _outTime = 6;
    public BreathingActivity(string name = "Breathing", string description = "This activity will help you relax by walking you through breathingin and out slowly. Clear your mind and focus on your breathing.") : base(name, description){
        
    }

    public void Run(){
        DisplayStartingMessage();

        Console.WriteLine($"How long, in seconds, would you like to breathe in for? (Enter for default: {_inTime})");
        string inTime = Console.ReadLine();
        if(inTime != ""){
            _inTime = int.Parse(inTime);
        }
        
        Console.WriteLine($"How long, in seconds, would you like to breathe out for? (Enter for default: {_outTime})");
        string outTime = Console.ReadLine();
        if(outTime != ""){
            _outTime = int.Parse(outTime);
        }

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        int timeToRun = _duration;
        while(timeToRun > 0){
            BreatheInPrompt();
            BreatheOutPrompt();
            Console.WriteLine();
            timeToRun -= (_inTime + _outTime);
        }

        DisplayEndingMessage();
        ShowSpinner(5);
    }

    private void BreatheInPrompt(){
        Console.Write("Breathe in...");
        ShowCountdown(_inTime);
        Console.WriteLine();
    }

    private void BreatheOutPrompt(){
        Console.Write("Breathe out...");
        ShowCountdown(_outTime);
        Console.WriteLine();
    }
}