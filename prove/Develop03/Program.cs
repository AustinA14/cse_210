using System;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Verily, verily, I say unto you, I give unto you to be the light of this people. A city that is set on a hill cannot be hid. Behold, do men light a candle and put it under a bushel? Nay, but on a candlestick, and it giveth light to all that are in the house; Therefore let your light so shine before this people, that they may see your good works and glorify your Father who is in heaven.";
        Reference reference2 = new Reference("3 Nephi", 12, 14, 16);
        Scripture scripture = new Scripture(reference2, scriptureText);
        string response = "";
        do
        {
            Console.Clear();
            Console.WriteLine("");
            scripture.Display();
            bool ifAllHidden = scripture.IsCompletelyHidden();
            if (ifAllHidden == true)
            {
                break;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("To continue, hit <Enter>. To exit, type 'quit': ");
            response = Console.ReadLine();
            if (response == "quit")
            {
                break;
            }
            scripture.SelectAndHideThree();
        } while (true);
    }
}