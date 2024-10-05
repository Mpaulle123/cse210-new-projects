using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public List<string> _entry = new List<string>();
    public void GetUserEntry(string entry)
    {
        _entry.Add(entry);
    }
    public void DisplayEntry()
    {
        Console.WriteLine("");
        foreach(var UserInput in _entry)
        {
            Console.WriteLine(UserInput);
        }
    }

    public void ClearEntry(int v)
    {
        _entry.Clear();
    }
}