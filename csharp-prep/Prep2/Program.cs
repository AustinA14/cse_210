using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse(answer);
        string letter;
        if (percentage >= 93)
        {
            letter = "A";
        }
        else if (percentage >= 90 && percentage < 93)
        {
            letter = "A-";
        }
        else if (percentage < 90 && percentage >= 87)
        {
            letter = "B+";
        }
        else if (percentage >= 83 && percentage < 87)
        {
            letter = "B";
        }
        else if (percentage >= 80 && percentage < 83)
        {
            letter = "B-";
        }
        else if (percentage < 80 && percentage >= 77)
        {
            letter = "C+";
        }
        else if (percentage >= 73 && percentage < 77)
        {
            letter = "C";
        }
        else if (percentage >= 70 && percentage < 73)
        {
            letter = "C-";
        }
        else if (percentage < 70 && percentage >= 67)
        {
            letter = "D+";
        }
        else if (percentage >= 63 && percentage < 67)
        {
            letter = "D";
        }
        else if (percentage >= 60 && percentage < 63)
        {
            letter = "D-";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is a/an {letter}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("You did not pass the class, but better luck next time!");
        }
    }
}