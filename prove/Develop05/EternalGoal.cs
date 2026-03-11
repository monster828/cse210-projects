public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int pointsRewared) : base(goalName, description, pointsRewared)
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