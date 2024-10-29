class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string description, int goalPoints) : base(goalName, description,goalPoints){}

    public override int Complete()
    {
        if (! _isCompleted)
        {
            _isCompleted = true;
            return GetGoalPoints();
        }

        return 0;
    }
}