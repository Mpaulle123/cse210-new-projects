using System.Diagnostics;

class Breathing : Activity
{
    

    public Breathing(string activityName, int duration, string description) : base(activityName, description, duration)
    {

    }

    public void Breath()
    {
        int intervals = 0;
        while (intervals < _activityTime) 
        {
            Console.WriteLine("Breath in...");
            System.Threading.Thread.Sleep(3000); 
            intervals += 3;
            if (intervals >= _activityTime) break;

            Console.WriteLine("Breath out...");
            System.Threading.Thread.Sleep(3000);
            intervals += 3;
        }
    }
    

    public override void Run()
    {
        Console.WriteLine();
        ShowTime();
        Console.WriteLine();
        DisplayStartingMessage();
        Console.WriteLine();
        Breath();
        Console.WriteLine();
        
        DisplayEndingMessage();
        Console.WriteLine();
        ShowCountDown();
    }

    

}