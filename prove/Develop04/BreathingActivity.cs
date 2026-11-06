using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void Countdown()
    {
        Console.Write("Breathe in...");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 1) Console.Write("\b \b");
        }
        Console.WriteLine();
        Console.Write("Breathe out...");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 1) Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}