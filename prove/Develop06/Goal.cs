abstract class Goal
{
    private string _description;
    private string _goalName;
    private int _goalPoints;
    protected bool _isCompleted;

    protected Goal(string goalName, string description, int goalPoints)
    {
        _description = description;
        _goalName = goalName;
        _goalPoints = goalPoints;
        _isCompleted = false;

    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public bool GetCompletion()
    {
        return false;
    }
    public void SetCompletion(bool iscompleted)
    {
        _isCompleted= iscompleted;
    }

    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public int GetGoalPoints()
    {
        return _goalPoints;
    }
    public void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public abstract int Complete();
}