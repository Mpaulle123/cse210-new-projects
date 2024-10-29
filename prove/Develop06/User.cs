using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class User
{
    private string _userName;
    private int _score;
    private List<Goal> goals;

    public User(string userName)
    {
        _userName = userName;
        _score = 0;
        goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your goals are: ");
        for (int i=0; i<goals.Count; i++)
        {
            string state;
            if (goals[i] is EternalGoal)
            {
                state = "[∞]"; // I added a infinite sign to mark it as eternal
            }
            else if (goals[i] is ChecklistGoal checklist && !checklist.GetCompletion())
            {
                state = $"[ ]--{checklist.GetProgress()}/{checklist.GetSteps()}";
            }
            else
            {
                state = goals[i].GetCompletion() ? "[x]" : "[ ]";
            }

            Console.WriteLine($"{i + 1}: {state} - {goals[i].GetGoalName()}, {goals[i].GetDescription()}.");
        }
    
        Console.WriteLine("Press any touch to make a choice.");
        Console.ReadKey();
    }

    public void MarkCompleted(Journal journal)
    {
        DisplayGoals();
        Console.WriteLine("Type the number of the goal you would like to mark as done: ");

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >=0 && index < goals.Count)
        {
            if (!goals[index].GetCompletion())
            {
                int points = goals[index].Complete();
                _score += points;

                Console.WriteLine("     ********          ********       ");
                Console.WriteLine("   ************      ************     ");
                Console.WriteLine(" ***************  ****************    ");
                Console.WriteLine(" **********************************   ");
                Console.WriteLine("  ********************************    ");
                Console.WriteLine("    ********* Great job ********      ");
                Console.WriteLine("      ************************        ");
                Console.WriteLine("         ******************           ");
                Console.WriteLine("           *************              ");
                Console.WriteLine("              *******                 ");
                Console.WriteLine("                ***                   ");
                Console.WriteLine("                 *                    ");
                Console.WriteLine($" You won {points} points!");
                Console.WriteLine($"Your new score is : {_score}");

                journal.RecordProgress(goals[index].GetType().Name, goals[index].GetDescription(), points);

                Console.WriteLine();
                Console.WriteLine("Press any touch to return to main menu");
                Console.ReadKey();

            }

            else
            {
                Console.WriteLine("This goal is already completed.");
            }

        }
        
        else
        {
            Console.WriteLine("Object number invalid.");
            Console.WriteLine("Press any touch to return to main menu.");
            Console.ReadKey();
        }  

    }

    public int GetScore()
    {
        return _score ;
    }
    

    public string GetName()
    {
        return _userName;
    }
    public void SetProgress(string userName)
    {
        _userName = userName;
    }


    public void DisplayScore()
    {
        Console.WriteLine($"Total score : {GetScore()}");
    }




}