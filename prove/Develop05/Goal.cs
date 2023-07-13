abstract class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDesc;
    protected bool _isComplete;

    public Goal(string goalType, string goalName, string goalDesc, int pointWorth, bool isComplete)
    {
        _goalType = goalType;
        _goalName = goalName;
        _goalDesc = goalDesc;
        _isComplete = isComplete;
    }

    public abstract void Completed();
    public abstract string GetListEnding();
    public abstract int RewardPoints();
    public abstract string GetGoalSave();

    public string GetGoalType()
    {
        return _goalType;
    }

    public bool GetCompleted()
    {
        return _isComplete;
    }

    public string GetCompleteString()
    {
        if (_isComplete == true)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDesc()
    {
        return _goalDesc;
    }
    
}