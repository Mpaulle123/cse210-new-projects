using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // I create a liste of activities
        List<Activity> activities = new List<Activity>();

        // Ajout d'activités à la liste
        activities.Add(new Running(DateTime.Now, "Running", 10, 5));
        activities.Add(new Bicycle(DateTime.Now, "Stationnary Bicycle", 20, 25));
        activities.Add(new Swimming(DateTime.Now, "Swinning", 20, 10));

        // I call the abstract method for each activity
        foreach (var activity in activities)
        {
            activity.GetSummary();
        }
    }
}