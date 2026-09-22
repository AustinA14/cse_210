using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a list of numbers. Enter 0 when done.");
        int number;
        List<int> numbers = new List<int>();
        do
        {
            string numberChoice = Console.ReadLine();
            number = int.Parse(numberChoice);
            numbers.Add(number);
        }   while (number != 0);
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        int length = numbers.Count - 1;
        double average = (double)sum / length;
        Console.WriteLine($"The average is: {average}");
        int max = numbers[0];
        foreach (int i in numbers)
        {
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}