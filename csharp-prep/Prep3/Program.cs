using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string answer = Console.ReadLine();
        // int magicNumber = int.Parse(answer);
        int guess;
        Random rand = new Random();
        int magicNumber = rand.Next(1, 101);
        do
        {
            Console.Write("What is your guess? ");
            string number = Console.ReadLine();
            guess = int.Parse(number);
            if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magicNumber != guess);
    }
}