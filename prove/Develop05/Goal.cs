public class Goal
{
    private string _goalName;
    private string _description;
    private int _pointsRewarded;

    public Goal(string goalName, string description, int pointsRewarded)
    {
        _goalName = goalName;
        _description = description;
        _pointsRewarded = pointsRewarded;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual string GetDetailsString()
    {
        return $"{_goalName} ({_description})";
    }

    public string GetStatusString()
    {
        if (IsComplete())
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }

    public virtual int RecordEvent()
    {
        return _pointsRewarded;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetSaveGoalString()
    {
        return $"{_goalName},{_description},{_pointsRewarded}";
    }
}