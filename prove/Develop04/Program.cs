using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        int pre_duration = 0;
        Random random = new Random();
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", pre_duration);
                breathing.ShowPrologue();
                breathing.GetDuration();
                Console.Write("Get ready...");
                breathing.ShowSpinner();
                Console.Clear();
                DateTime startTime = DateTime.Now;
                bool finished = false;
                while(finished == false)
                {
                    breathing.Countdown();
                    finished = breathing.CheckTimer(startTime);
                }
                breathing.ShowEpilogue();
                breathing.ShowSpinner();
            }
            else if (choice == "2")
            {
                Console.Clear();
                List<string> promptList = new List<string> {"Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
                List<string> questionList = new List<string> {"Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
                ReflectionActivity reflection = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", pre_duration);
                reflection.ShowPrologue();
                reflection.GetDuration();
                Console.Write("Get ready...");
                reflection.ShowSpinner();
                Console.Clear();
                DateTime startTime = DateTime.Now;
                bool finished = false;
                int randomIndex = random.Next(promptList.Count);
                Console.WriteLine(promptList[randomIndex]);
                reflection.ShowSpinner();
                while(finished == false)
                {
                    int randomIndex2 = random.Next(questionList.Count);
                    Console.WriteLine(questionList[randomIndex2]);
                    reflection.ShowSpinner();
                    finished = reflection.CheckTimer(startTime);
                }
                reflection.ShowEpilogue();
                reflection.ShowSpinner();
            }
            else if (choice == "3")
            {
                Console.Clear();
                List<string> promptList = new List<string> {"Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
                ListingActivity listing = new ListingActivity(promptList, "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", pre_duration);
                listing.ShowPrologue();
                listing.GetDuration();
                Console.Write("Get ready...");
                listing.ShowSpinner();
                Console.Clear();
                DateTime startTime = DateTime.Now;
                int randomIndex = random.Next(promptList.Count);
                listing.DisplayPrompt(randomIndex);
                listing.GetResponse(startTime);
                listing.ShowEpilogue();
                listing.ShowSpinner();
            }
            else
            {
                break;
            }
        }
    }
}