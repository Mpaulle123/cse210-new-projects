class Journal
{
    private string _filePath;
    private List<string> _history;
    
    public Journal(string filePath)
    {
        this._filePath = filePath;
        _history = new List<string>();
    }

    public void RecordProgress(string goalName, string goalDescription, int pointsWon)
    {
        string entries = $"{DateTime.Now}: {goalName} - {goalDescription} marked as done. You won: {pointsWon}";
        _history.Add(entries);

        using (StreamWriter writer = new StreamWriter(_filePath, true))
        {
            writer.WriteLine(entries);
        }

    }

    public void LoadFromFile()
    {
        if (File.Exists(_filePath))
        {
            _history = new List<string>(File.ReadAllLines(_filePath));
        }
    }

    public void DisplayJournal()
    {
        Console.WriteLine();
        Console.WriteLine("Here is the history of your progress: ");
        Console.WriteLine();
        if (_history.Count == 0)
        {
            Console.WriteLine("No goal marked as done.");
        }
        else
        {
            foreach(var entries in _history)
            {
                Console.WriteLine(entries);
            }
        }

        Console.WriteLine("Press any touch to return to the main menu.");
        Console.ReadKey();
    }  

}