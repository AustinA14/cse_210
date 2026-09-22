using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static void PromptUserBirthYear(out int birthYear)
        {
            Console.Write("What year were you born? ");
            birthYear = int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number)
        {
            return number * number;
        }
        static void DisplayResult(string userName, int squareNumber, int birthYear)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
            int yearsOld = 2026 - birthYear;
            Console.WriteLine($"{userName}, you will turn {yearsOld} this year.");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int birthYear;
        PromptUserBirthYear(out birthYear);
        int numSquared = SquareNumber(favNum);
        DisplayResult(name, numSquared, birthYear);
    }
}