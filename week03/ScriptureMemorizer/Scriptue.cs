public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void Display()
    {
        Console.Write(_reference.GetDisplay() + " ");

        foreach (Word w in _words)
        {
            Console.Write(w.GetDisplay() + " ");
        }

        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        List<Word> visible = new List<Word>();

        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                visible.Add(w);
            }
        }

        if (visible.Count > 0)
        {
            int index = _random.Next(visible.Count);
            visible[index].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

