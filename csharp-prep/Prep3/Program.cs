using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        bool numberGuessed = false;
        Console.WriteLine("I have generated the random integer number!");
        
        while(!numberGuessed){
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            if(guess < number){
                Console.WriteLine("Higher");
            }

            if(guess > number){
                Console.WriteLine("Lower");
            }

            if(guess == number){
                Console.WriteLine("You guessed it!");
                numberGuessed = true;
            }
        }
    }
}