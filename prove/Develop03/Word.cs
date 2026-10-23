public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _isHidden = false;
        _word = word;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public string GetRenderedText()
    {
        if (_isHidden)
        {
            return "____";
        }
        else
        {
            return _word;
        }
    }
    public bool CheckIfHidden()
    {
        return _isHidden;
    }
}