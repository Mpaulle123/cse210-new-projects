public abstract class Activity
{
    protected DateTime _date;
    protected string _activityName;
    protected double _duration;

    public Activity(DateTime date, string actitityName, double duration)
    {
        _date = date;
        _activityName = actitityName;
        _duration = duration;
    }


    public abstract void GetSummary();
}