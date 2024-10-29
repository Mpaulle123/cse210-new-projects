using System;

class Program
{
    static void Main(string[] args)
    {
        User user = new User("Paulle"); // I added a User class to manage all the actions of the user
        Journal journal = new Journal(@"C:\Users\Paulle Mahouangou\Desktop\journal.txt"); // i added a Journal class to manage all about the storing

        //load in the file when run
        journal.LoadFromFile();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Total score: {user.GetScore()}\n");
            Console.WriteLine("Menu :");
            Console.WriteLine("1: Display list of goals");
            Console.WriteLine("2: Record an event");
            Console.WriteLine("3: Add a new goal");
            Console.WriteLine("4: Display the total score");
            Console.WriteLine("5: Quit");
            Console.Write("Chose an option : ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    user.DisplayGoals();
                    break;
                case "2":
                    user.MarkCompleted(journal);
                    break;
                case "3":
                    CreateNewGoal(user);
                    break;
                case "4":
                    user.DisplayScore();
                    journal.DisplayJournal();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalide option. Press any touch to return to the main menu.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void CreateNewGoal(User user)
    {
        Console.WriteLine("Chose the goal you want to create :");
        Console.WriteLine("1: Simple goal");
        Console.WriteLine("2: Eternal goal");
        Console.WriteLine("3: CheckList goal");
        Console.Write("Enter your choice : ");

        string choice = Console.ReadLine();

        Console.WriteLine();
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Give a short description of your goal: ");
        string description = Console.ReadLine();
        Console.WriteLine();
        Console.Write("How many points will win when done: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                user.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                user.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine();
                Console.Write("How many time does the goal need to be done to be completed? : ");
                int steps = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("How many points bonus will you win when completed: ");
                int bonus = int.Parse(Console.ReadLine());
                user.AddGoal(new ChecklistGoal(name, description, points, steps, bonus ));
                break;
            default:
                Console.WriteLine("invalide entry.");
                break;
        }
        Console.WriteLine("Successfully added !");
        Console.WriteLine();
        Console.WriteLine("Press any touch to return to the main menu.");
        Console.ReadKey();
    }
}
