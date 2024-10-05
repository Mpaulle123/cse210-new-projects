using System;

public class Prompt

{
    public static readonly Random _random = new Random();
    public static readonly List<string> _prompts = new List<string>
    {
        "With who did you have an interesting conversation ?",
        "What different thing did you try today ?",
        "What come to your mind now ?",
        "What do you want to remember from today ? ",
        "Write one thing that you would do differently next time ",
        
    };

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }


}