using System;

// Exceeding Requirements:
// Level System: Gain points from completing your goals to level up. 
    // This feature adds a gamification element that encourages users to stay consisten and complete their goals by providing an additional sense of progress and achievement.

class Program
{
    private static int _score;
    private static List<Goal> _goals;

    static void Main(string[] args)
    {
        bool running = true;

        Menu menu = new();
        _goals = new List<Goal>();
        LevelSystem levelSystem = new LevelSystem(_score);
        while (running)
        {
            DisplayScore();                    
            levelSystem.CheckLevel(_score);
            Console.WriteLine();
            int chosenOption = menu.MainMenu();

            switch (chosenOption)
            {
                case 1:
                    // Create New Goal
                    CreateGoal();
                    break;

                case 2:
                    // List Goals
                    ShowGoals();
                    break;

                case 3:
                    // Save Goals
                    SaveSystem saveSystem = new SaveSystem();
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();
                    saveSystem.SaveGoals(filename, _goals, _score);
                    break;

                case 4:
                    // Load Goals
                    saveSystem = new SaveSystem();
                    Console.Write("What is the filename for the goal file? ");
                    filename = Console.ReadLine();
                    _goals = saveSystem.LoadGoals(filename, out _score);
                    levelSystem = new LevelSystem(_score);
                    break;

                case 5:
                    // Record Event
                    RecordEvent();
                    break;

                case 6:
                    // Quit
                    running = false;
                    break;
            }
        }
    }

    static void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
    }

    static void CreateGoal()
    {
        Menu menu = new();

        // Create and return the chosen goal to create from the menu
        int createdGoal = menu.CreateGoalMenu();

        // Get Name of the goal
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        // Get Description of the goal
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        // Get Reward of the goal
        Console.Write("What is the amount of points associated with this goal? ");
        int reward = int.Parse(Console.ReadLine());

        switch (createdGoal)
        {
            case 1:
                // Simple Goal
                SimpleGoal simpleGoal = new SimpleGoal(name, description, reward, false);
                _goals.Add(simpleGoal);
                break;

            case 2:
                // Eternal Goal
                EternalGoal eternalGoal = new EternalGoal(name, description, reward);
                _goals.Add(eternalGoal);
                break;

            case 3:
                // Checklist Goal
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int times = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, reward, times, 0, bonus);
                _goals.Add(checklistGoal);
                break;
        }
    }

    static void RecordEvent()
    {
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}.  {goal.GetDescription()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int recorded = int.Parse(Console.ReadLine()) - 1;
        int gainScore = _goals[recorded].RecordEvent();

        _score += gainScore;

        Console.WriteLine($"Congratulations! You have earned {gainScore} points!");
        Console.WriteLine($"You now have {_score} points.");
    }

    static void ShowGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}.  {_goals[i].GetStatusString()} {_goals[i].GetDetailsString()}");
        }
    }
}