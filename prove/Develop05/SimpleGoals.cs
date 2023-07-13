class SimpleGoal : Goal
{
    private int _pointWorth;
    public SimpleGoal(string goalType, string goalName, string goalDesc, int pointWorth, bool isComplete) : base(goalType, goalName, goalDesc, pointWorth, isComplete)
    {
        
        _pointWorth = pointWorth;
    }

    public override void Completed()
    {
        _isComplete = true;
    }

    public override string GetListEnding()
    {
        return "";
    }

    public override int RewardPoints()
    {
        return _pointWorth;
    }

    public override string GetGoalSave()
    {
        return $"{GetGoalType()},{GetGoalName()},{GetGoalDesc()},{RewardPoints()},{GetCompleted()},0,0,0";
    }
}