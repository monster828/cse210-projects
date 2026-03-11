using System.IO;
public class SaveSystem
{
    public void SaveGoals(string filename, List<Goal> goals, int score)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(score);
            foreach(Goal goal in goals)
            {
                outputFile.WriteLine($"{goal.GetSaveGoalString()}");
            }
        }
    }

    public List<Goal> LoadGoals(string filename, out int score)
    {
        List<Goal> goals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);

        if (lines.Length > 0)
        {
            score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] section = line.Split(":");
                string className = section[0];
                string[] parts = section[1].Split(",");

                string goalName = parts[0];
                string goalDescription = parts[1];
                int reward = int.Parse(parts[2]);

                switch (className)
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, reward, bool.Parse(parts[3]));
                        goals.Add(simpleGoal);
                        break;
                    
                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, reward);
                        goals.Add(eternalGoal);
                        break;
                    
                    case "ChecklistGoal":
                        ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, reward, int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                        goals.Add(checklistGoal);
                        break;
                }
            }
        }
        else
        {
            score = 0;
        }

        return goals;
    }
}