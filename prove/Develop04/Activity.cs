using System.Threading;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void ShowPrologue()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
    }
    public void ShowSpinner()
    {
        for(int i = 0; i < 3; i++) {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void ShowEpilogue()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }
    public bool CheckTimer(DateTime beforeTime)
    {
        DateTime currenttime = DateTime.Now;
        if ((currenttime - beforeTime).TotalSeconds >= _duration)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}