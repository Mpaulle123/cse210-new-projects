class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int goalPoints) : base(goalName, description, goalPoints) { }

    public override int Complete()
    {
        return GetGoalPoints();
    }

}