class ChecklistGoal : Goal
{
    private int _totalSteps;
    private int _bonus;
    private int _progress;

    public ChecklistGoal(string goalName, string description, int goalPoints, int totalSteps, int bonus): base(goalName, description, goalPoints)
    {
        _totalSteps = totalSteps;
        _bonus = bonus;
        _progress = 0;
    }

    public int GetSteps()
    {
        return _totalSteps;
    }
    public void SetSteps(int totalSteps)
    {
        _totalSteps = totalSteps;
    }

    public int GetProgress()
    {
        return _progress;
    }
    public void SetPrrogress(int progress)
    {
        _progress = progress;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public override int Complete()
    {
        if (_progress <_totalSteps)
        {
            _progress++;

            
            if (_progress == _totalSteps)
            {
                _isCompleted = true;

                return _bonus + GetGoalPoints();
            }

            return GetGoalPoints();
        }

        return 0;
    }

}