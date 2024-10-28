class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _activityTime;
    protected DateTime _date;

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

    public string GetName()
    {
        return _activityName;
    }
    public void SetName(string activityName)
    {
        _activityName = activityName;
    }
    public string Getdescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetTime()
    {
        return _activityTime;
    }
    public void SetTime(int duration)
    {
        _activityTime = duration;
    }
    public DateTime GetDate()
    {
        return _date;
    }
    public void SetDate(DateTime date)
    {
        _date = date;
    }

}