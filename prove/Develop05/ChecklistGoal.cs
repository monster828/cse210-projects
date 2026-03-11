public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _targetAmount;
    private int _bonus;

    public ChecklistGoal(string goalName, string description, int pointsRewared, int targetAmount, int amountCompleted, int bonus) : base(goalName, description, pointsRewared)
    {
        _targetAmount = targetAmount;
        _bonus = bonus;
        
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        int gainScore = base.RecordEvent();

        _amountCompleted++;
        if (_amountCompleted == _targetAmount)
        {
            gainScore += _bonus;
        }

        return gainScore;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _targetAmount;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_targetAmount}";
    }

    public override string GetSaveGoalString()
    {
        return $"ChecklistGoal:{base.GetSaveGoalString()},{_targetAmount},{_amountCompleted},{_bonus}";
    }
}