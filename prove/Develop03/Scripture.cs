class Scripture
{

    private List<Reference> _verses;
    private List<string> _wordsOfVerse;
    private Word _words;
    private Random _random;

    public Scripture(List<Reference> verses)
    {
        this._verses = verses;
        this._wordsOfVerse = verses.SelectMany(v => v.GetText().Split(" ")).ToList();
        this._random = new Random();
        this._words = new Word();
    }

    public void Display()
    {
        while (_wordsOfVerse.Any(m => m != "__"))
        {
            Console.Clear();
            DisplayVerse();
            if (!Stop())
            {
                break;
            }
            Console.ReadLine();
        }

        Console.WriteLine("All words have been hiden");
    }

    private void DisplayVerse()
    {
        foreach (Reference verse in _verses)
        {
            Console.WriteLine(verse.GetReference());
            foreach (string word in verse.GetText().Split(' '))
            {
                Console.Write(_wordsOfVerse.Contains(word) ? word + " " : "__");
            }
            Console.WriteLine();
        }
    }

    private bool Stop()
    {
        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Q)
        {
            return false;
        }

        int index = _words.ChooseRandomWord(_wordsOfVerse, _random);
        _wordsOfVerse[index] = "__";
        return true;
    }

    
}
