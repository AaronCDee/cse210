using System;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;

        while(number > 0){
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if(number > 0){
                numbers.Add(number);
            }
        }

        int max = numbers[0];
        int avg = 0;
        int sum = 0;

        foreach(int num in numbers){
            if(num > max){
                max = num;
            }
            sum += num;
        }

        avg = sum / numbers.Count();

        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Avg: {avg}");
    }
}