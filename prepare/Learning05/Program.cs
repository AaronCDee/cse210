using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5);
        Console.WriteLine(square.GetArea());

        Rectangle rect = new Rectangle(5, 4);
        Console.WriteLine(rect.GetArea());

        Circle circle = new Circle(5);
        Console.WriteLine(circle.GetArea());
    }
}