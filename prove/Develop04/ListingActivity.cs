using System.Threading;

class ListingActivity : Activity
{
    private List<string> _promptList;
    private List<string> _answerList = new List<string>();

    public ListingActivity(List<string> promptList, string name, string description, int duration) : base(name, description, duration)
    {
        _promptList = promptList;
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayPrompt(int index)
    {
        Console.WriteLine(_promptList[index]);
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i > 1) Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    public void GetResponse(DateTime startTime)
    {
        bool finished = false;
        while(finished == false)
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            _answerList.Add(answer);
            finished = CheckTimer(startTime);
        }
    }
}