public class Goal
{
    private string _goalName;
    private string _description;
    private int _pointsRewared;

    public Goal(string goalName, string description, int pointsRewared)
    {
        _goalName = goalName;
        _description = description;
        _pointsRewared = pointsRewared;
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
        return _pointsRewared;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetSaveGoalString()
    {
        return $"{_goalName},{_description},{_pointsRewared}";
    }
}