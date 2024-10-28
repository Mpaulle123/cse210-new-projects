class Reflection : Activity
{
    private List<string> _subjects;
    private Dictionary<string, List<string>> _questionsPerSubjects;

    public Reflection(string activityName, int duration, string description) : base(activityName, description, duration)
    {
        DisplayPromptsAndQuestions();
    }

    public void DisplayPromptsAndQuestions()
    {
        _subjects = new List<string>
        {
            "Personal development: Think of a time when you did something really difficult.",
            "Feeling and emotions: What emotion did you feel the most today? Describe the situation that triggered it",
            "Relationship with God: Reflect on a circumstance where God's love guided you",
        };

        _questionsPerSubjects = new Dictionary<string, List<string>>
        {
            {"Personal development: Think of a time when you did something really difficult.", new List<string>
                {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
                }

            },

            {
                "Feeling and emotions: What emotion did you feel the most today? Describe the situation that triggered it", new List<string>
                {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
                }

            },

            {
                "Relationship with God: Reflect on a circumstance where God's love guided you", new List<string>
                {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
                }

            },

        };

    }

    public override void Run()
    {
        Console.WriteLine();
        ShowTime();
        Console.WriteLine();
        DisplayStartingMessage();
        string _prompt = GetPrompt();
        Console.WriteLine();
        Console.WriteLine($"Lets talk about {_prompt}");

        List<string> _questions = _questionsPerSubjects[_prompt];

        int intervals = 0;
        foreach (var question in _questions)
        {
            if (intervals >= _activityTime) break;

            Console.WriteLine($"\nQuestion : {question}");
            Console.WriteLine("You have 10 secondes to answerd");

            var startQuestion = DateTime.Now;
            string response = WaitAnswer(10);

            if (response.Equals("terminé", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You stoped the activity");
                break;
            }

            intervals += (int)(DateTime.Now - startQuestion).TotalSeconds;
        }

        Console.WriteLine();
        DisplayEndingMessage();
        Console.WriteLine();
        ShowCountDown();


    }

    private string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_subjects.Count);

        return _subjects[index];
    }

    private string WaitAnswer(int secondes)
    {
        DateTime endTime = DateTime.Now.AddSeconds(secondes);
        string response = null;
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable)
            {
                response = Console.ReadLine();
                break;
            }

        }

        return response ?? "";

    }

    public void EndingMessage()
    {
        Console.WriteLine("Well done!!");
    }





}