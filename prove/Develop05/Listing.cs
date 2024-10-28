class Listing : Activity
{
    private List<string> _questions;
    private Dictionary<string, string> _reponses;

    public Listing(string activityName,  int activityTime, string description) : base(activityName, description, activityTime)
    {
        GetQuestion();
        _reponses = new Dictionary<string, string>();
    }

    private void GetQuestion()
    {
        _questions = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
        }

    public override void Run()
    {
        Console.WriteLine();
        ShowTime();
        Console.WriteLine();
        DisplayStartingMessage();

        Random random = new Random();
        List<string> _remainingQuestions = new List<string>(_questions);
            
        int intervals = 0;

        while (_remainingQuestions.Count > 0 && intervals < _activityTime)
        {
            int index = random.Next(_remainingQuestions.Count);
            string _question = _remainingQuestions[index];
            _remainingQuestions.RemoveAt(index);

            Console.WriteLine($"\nQuestion : {_question}");
            Console.Write("Your Answer : ");

            DateTime startQuestion = DateTime.Now;
            string reponse = Console.ReadLine();
            intervals += (int)(DateTime.Now - startQuestion).TotalSeconds;

            if (!string.IsNullOrWhiteSpace(reponse))
            {
                _reponses[_question] = reponse;
            }

                if (intervals >= _activityTime)
                {
                    Console.WriteLine("\nTime out for this activity.");
                    break;
                }
            }
        Console.WriteLine();
        DisplayReponses();
        Console.WriteLine();
        DisplayReponses();
        Console.WriteLine();
        DisplayEndingMessage();
        Console.WriteLine();
        ShowCountDown();
    }

        private void DisplayReponses()
        {
            Console.WriteLine("\n--- Here is the summary of this section ---");
            foreach (var question in _questions)
            {
                if (_reponses.TryGetValue(question, out string reponse))
                {
                    Console.WriteLine($"Question : {question}");
                    Console.WriteLine($"Answer : {reponse}");
                }
                else
                {
                    Console.WriteLine($"Question : {question}");
                    Console.WriteLine("Answer : (No answer provided)");
                }
                Console.WriteLine();
            }
        }

    public void EndingMessage()
    {
        Console.WriteLine("Well done!!");
    }


}