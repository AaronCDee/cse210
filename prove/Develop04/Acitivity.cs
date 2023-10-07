using System;
using System.Runtime.CompilerServices;
using System.Threading;

class Activity{
    protected string _name;
    protected string _description;
    protected int _duration = 30;

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage(){
        Console.Clear();
        string startingMessage = $"Welcome to the {_name} Activity\r\n\r\n{_description}\r\n\r\nHow long, in seconds, would you like for your session? (Enter for default: {_duration})";
        Console.WriteLine(startingMessage);
        
        string timeInput = Console.ReadLine();
        if(timeInput != ""){
            int duration = int.Parse(timeInput);
            SetDuration(duration);
        }
    }
    public void DisplayEndingMessage(){
        string endingMessage = $"Well done!\r\n\r\nYou have completed another {_duration} seconds of the {_name} Activity";
        Console.WriteLine(endingMessage);
    }
    public static void ShowSpinner(int seconds, bool inline = false)
    {
        int delay = 200;
        int duration = seconds * 1000;
        if(inline){
            Console.Write(" ");
        }
        while (duration > 0)
        {
            Console.Write("\b/");
            Thread.Sleep(delay);
            
            Console.Write("\b-");
            Thread.Sleep(delay);
            
            Console.Write("\b\\");
            Thread.Sleep(delay);
            
            Console.Write("\b|");
            Thread.Sleep(delay);

            duration -= delay * 4;
        }
        
        Console.Write("\b \b"); // Clear the spinner when done
        
        Console.WriteLine();
    }
    public static void ShowCountdown(int seconds){
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000); // Delay for 1 second
            Console.Write("\b");
        }
        Console.Write(" \b");
    }

    public void SetDuration(int duration){
        _duration = duration;
    }

}