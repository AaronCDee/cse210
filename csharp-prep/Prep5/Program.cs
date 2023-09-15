using System;
using System.Xml.Serialization;

class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName(){
        Console.Write("What's your name? ");
        return Console.ReadLine();
    }
    static int PromptUserNumber(){
        Console.Write("What's your lucky integer number? ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int num){
        return num*num;
    }
    static void DisplayResult(string name, int numSquared){
        Console.WriteLine($"Your name is: {name}");
        Console.WriteLine($"Your lucky number squared is: {numSquared}");
    } 
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        int numSquared = SquareNumber(num);
        DisplayResult(name, numSquared);
    }
}