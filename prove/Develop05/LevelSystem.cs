public class LevelSystem
{
    private int _level;
    private readonly int _pointsPerLevel = 100;
    private readonly string[] _levelNames =
    {
        "Starting Out",
        "Building Momentum",
        "Consistent",
        "Committed",
        "Accomplished",
        "Master"
    };

    public LevelSystem(int score)
    {
        SetLevel(score);
    }

    void SetLevel(int score)
    {
        _level = (int)MathF.Floor(score/_pointsPerLevel);
    }

    public void CheckLevel(int newScore)
    {
        int currentLevel = _level;
        SetLevel(newScore);

        if (currentLevel == _level)
        {
            int distanceFromLevel = _pointsPerLevel - (newScore % _pointsPerLevel);
            float percentage = (float)distanceFromLevel / _pointsPerLevel;

            string nextLevel = GetLevelString(_level + 1);

            Console.WriteLine(CompletionBar(percentage, 7));
            Console.WriteLine($"You are {distanceFromLevel} from {nextLevel}");
        }
        else
        {
            Console.WriteLine($"Congrats! You have leveled up from {GetLevelString(currentLevel)} to {GetLevelString(_level)}!!!");
        }
    }

    private string GetLevelString(int level)
    {
        if (level > _levelNames.Length)
        {
            return _levelNames.Last();
        }
        else
        {
            return _levelNames[level];
        }
    }

    private string CompletionBar(float percentage, int size)
    {
        string bar = "";
        int amountEmpty = (int)MathF.Round(percentage * size);
        for (int i = 0; i < size; i++)
        {
            if (i >= amountEmpty)
            {
                // Display Empty
                bar = "█" + bar;
            }
            else
            {
                // Display Full
                bar = "░" + bar;
            }
        }

        return bar;
    }
}