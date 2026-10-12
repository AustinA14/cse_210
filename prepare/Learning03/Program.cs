using System;

class Program
{
    static void Main(string[] args)
    {
        // test constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // test getters and setters
        fraction3.SetTop(5);
        fraction3.SetBottom(3);
        Console.WriteLine(fraction3.GetTop());
        Console.WriteLine(fraction3.GetBottom());

        // test methods
        fraction2.SetTop(1);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        fraction2.SetTop(5);
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        fraction3.SetTop(3);
        fraction3.SetBottom(4);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        fraction3.SetTop(1);
        fraction3.SetBottom(3);
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        Fraction fraction4 = new Fraction();
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            int top = random.Next(1, 11);
            int bottom = random.Next(1, 11);
            fraction4.SetTop(top);
            fraction4.SetBottom(bottom);
            Console.WriteLine($"Fraction {i + 1}: string: {fraction4.GetFractionString()} Number: {fraction4.GetDecimalValue()}");
        }
    }
}