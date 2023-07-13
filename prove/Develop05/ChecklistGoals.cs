class ChecklistGoal : Goal
{
    private int _doneTimes;
    private int _totalTimes;
    private int _bonus;
    private int _pointWorth;

    public ChecklistGoal(string goalType, string goalName, string goalDesc, int pointWorth, bool isComplete, int totalTimes, int doneTimes, int bonus) : base(goalType, goalName, goalDesc, pointWorth, isComplete)
    {
        _doneTimes = doneTimes;
        _totalTimes = totalTimes;
        _bonus = bonus;
        
        _pointWorth = pointWorth;
    }

    public override void Completed()
    {
        if (_doneTimes == _totalTimes)
        {
            _isComplete = true;
        }
        else
        {
            _isComplete = false;
        }
        _doneTimes++;
    }

    public override int RewardPoints()
    {
        if (_doneTimes == _totalTimes)
        {
            return _pointWorth+_bonus;
        }
        else
        {
            return _pointWorth;
        }
    }

    public override string GetListEnding()
    {
        return $"-- Currently completed: {_doneTimes}/{_totalTimes}";
    }

    public override string GetGoalSave()
    {
        return $"{GetGoalType()},{GetGoalName()},{GetGoalDesc()},{RewardPoints()},{GetCompleted()},{_totalTimes},{_doneTimes},{_bonus}";
    }
}