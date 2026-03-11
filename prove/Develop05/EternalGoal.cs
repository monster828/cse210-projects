public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int pointsRewarded) : base(goalName, description, pointsRewarded)
    {
        
    }

    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }

    public override string GetSaveGoalString()
    {
        return $"EternalGoal:{base.GetSaveGoalString()}";
    }
}