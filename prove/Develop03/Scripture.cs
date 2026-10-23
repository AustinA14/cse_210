public class Scripture
{
    private List<Word> _scripture;
    private Reference _reference;
    private Random _random = new Random();

    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        string[] words = scriptureText.Split();
        _scripture = new List<Word>();
        foreach (string word in words)
        {
            Word word1 = new Word(word);
            _scripture.Add(word1);
        }
    }
    public void SelectAndHideThree()
    {
        int tally = 0;
        foreach (Word word in _scripture)
        {
            bool isItHidden = word.CheckIfHidden();
            if (isItHidden == false)
            {
                tally += 1;
            }
        }
        int numberToHide = 0;
        if (tally > 3)
        {
            numberToHide = 3;
        }
        else
        {
            numberToHide = tally;
        }
        int index = 0;
        bool isHidden = false;
        for (int i = 0; i < numberToHide; i++)
        {
            do 
            {
                index = _random.Next(_scripture.Count);
                isHidden = _scripture[index].CheckIfHidden();
            } while (isHidden == true);
            _scripture[index].Hide();
        }
    }
    public void Display()
    {
        _reference.Display();
        Console.WriteLine("");
        foreach (Word word in _scripture)
        {
            Console.Write($"{word.GetRenderedText()} ");
        }
    }
    public bool IsCompletelyHidden()
    {
        
        int tally = 0;
        foreach (Word word in _scripture)
        {
            bool isItHidden = word.CheckIfHidden();
            if (isItHidden == false)
            {
                return false;
            }
        }
        return true;
    }
}