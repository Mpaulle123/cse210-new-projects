using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program 
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        string filePath = @"C:\Users\Paulle Mahouangou\Desktop\Activities.json";


        LoadFromFile(ref activities, filePath);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu :");
            Console.WriteLine("1: Do an activity");
            Console.WriteLine("2: Save session"); //I showed creativity here
            Console.WriteLine("3: Load session"); //I showed creativity here
            Console.WriteLine("4: Show my progress"); //I showed creativity here
            Console.WriteLine("5: Quit");
            Console.Write("Choose an option : ");

            string choix = Console.ReadLine();

            switch (choix) //I showed creativity here
            {
                case "1":
                    DoAnActivity(activities);
                    break;
                case "2":
                    SaveToFile(activities, filePath);
                    break;
                case "3":
                    LoadFromFile(ref activities, filePath);
                    break;
                case "4":
                    ShowProgress(activities);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a valid option.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void DoAnActivity(List<Activity> activities)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("4: Return to main menu");
            Console.Write("Your choice : ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new Breathing("Daily breathing", 10, "This activity will help you relax by guiding you through breathing exercises.");
                    break;
                case "2":
                    activity = new Reflection("Self-reflection", 30, "Reflect on times in your life when you have shown strength and resilience.");
                    break;
                case "3":
                    activity = new Listing("Listing time", 30, "List the good things in your life as much as you can in a given time.");
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please enter a valid option.");
                    Console.ReadKey();
                    continue;
            }

            if (activity != null)
            {
                activity.Run();
                activities.Add(activity);
            }
        }
    }

    static void SaveToFile(List<Activity> activities, string filePath)
    {
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            string jsonString = JsonSerializer.Serialize(activities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);
            Console.WriteLine("Session successfully saved!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error during save: {e.Message}");
        }
        Console.WriteLine("Press Enter to return to the main menu.");
        Console.ReadKey();
    }

    static void LoadFromFile(ref List<Activity> activities, string filePath)
    {
        if (File.Exists(filePath))
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            File.WriteAllText(filePath, "[]");
            Console.WriteLine("No precious Session found. A new session file has been created.");
        }
        try
        {
            string jsonString = File.ReadAllText(filePath);
            activities = JsonSerializer.Deserialize<List<Activity>>(jsonString) ?? new List<Activity>();
            Console.WriteLine("Session successfully loaded!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error during load: {e.Message}");
        }

    }

    static void ShowProgress(List<Activity> activities)
    {
        Console.Clear();
        if (activities.Count > 0)
        {
            Console.WriteLine("Here is your progress:");
            foreach (var activity in activities)
            {
                Console.WriteLine();
                Console.WriteLine($"Date: {activity.GetTime()} \nActivity: {activity.GetName()} \nDescription: {activity.Getdescription} \nDuration: {activity.GetTime()} minutes.");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("No activities recorded yet.");
        }
        Console.WriteLine("Press Enter to return to the main menu.");
        Console.ReadKey();
    }
}