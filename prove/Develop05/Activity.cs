class Activity
{
    public string _activityName{ get; private set; }
    public string _description{ get; private set; }
    public int _activityTime{ get; private set; }
    public DateTime _date { get; set; }

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _activityTime = duration;
        _date = DateTime.Now;
    }

    public virtual void Run()
    {
        ShowTime();
        DisplayStartingMessage();
        ShowCountDown();
        DisplayEndingMessage();
    }


    public void ShowTime()
    {
        Console.WriteLine($"Time assigned to the activity {_activityName} is {_activityTime} secondes.");

    }

    protected virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Description of the activity : {_description}");

    }

    public void ShowCountDown()
    {
        for (int i = 10; i > 0; i --)
        {
            Console.WriteLine($"{i}");
            System.Threading.Thread.Sleep(500);
            
        }
        Console.WriteLine("The activity is finished");
    }

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!! The activity {_activityName} is finished. Keep it up!!!");
    }

  


}