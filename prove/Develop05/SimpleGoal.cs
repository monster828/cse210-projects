public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string goalName, string description, int pointsRewared, bool isComplete) : base(goalName, description, pointsRewared)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetSaveGoalString()
    {
        return $"SimpleGoal:{base.GetSaveGoalString()},{_isComplete}";
    }
}