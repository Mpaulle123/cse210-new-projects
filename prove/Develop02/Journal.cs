using System;
using System.Runtime;
using System.Runtime.CompilerServices;

class Journal
{

    // I want to add the user's name in the code so that it is personalized
// I wanted to give an option to the user to enter first his first name but i think for the moment 
// it is easier to set it in the code
    public string _firstName = "Paulle Mahouangou";

    // I add the time so that the user can remember exactly when he wrote
    public List<(string Prompt, string Input, DateTime Date)> _entries = new List<(string, string, DateTime)>();

    public void AddEntry(string promt, string input)
    {
        _entries.Add((promt, input, DateTime.Now));

    }
    public void DisplayAll()
    {
        // I add here an idex (number) to each prompt and input so that the user have the option to erase. 
        Console.WriteLine($"Here is the content of your Journal {_firstName} :");
        for (int i = 0; i < _entries.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_entries[i].Date} - Quote: {_entries[i].Prompt}");
            Console.WriteLine($" {_entries[i].Input}");
        }
    }

// i added the methode ClearEntry that exceed the requirements
// it uses the number added in the methode DisplayAll as an index to arase the good Prompt-input combinaition
    public void ClearEntry(int index)
    {
        if (index >= 0 && index < _entries.Count)
        {
            _entries.RemoveAt(index);
            Console.WriteLine("Successfully erased.");
        }
        else
        {
            Console.WriteLine("Invalide entry.");
        }
    }
    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Prompt},{entry.Input}");
            }
        }
        Console.WriteLine($"Your input have been successfully saved in {filePath}");
    }

    public void LoadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            _entries.Clear();
            using StreamReader reader = new StreamReader(filePath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(",");
                if (parts.Length == 2)
                {
                    _entries.Add((parts[0], parts[1], DateTime.Now));
                }
            }
        }

        else
        {
            Console.WriteLine("File not found");
        }
    }
}




