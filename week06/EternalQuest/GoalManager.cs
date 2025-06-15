using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _goalsCompleted = 0;

    public int Score => _score;
    public int Level => _score / 100;
    public bool HasBadge => _goalsCompleted >= 5;

    public void CreateGoal()
    {
        Console.WriteLine("\nSelect the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points on completion: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nYour Goals:");
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals found.");
            return;
        }

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            writer.WriteLine(_goalsCompleted);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goalsCompleted = int.Parse(lines[1]);

        _goals.Clear();

        for (int i = 2; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    var sg = new SimpleGoal(name, description, points);
                    if (isComplete) sg.RecordEvent();  // Mark complete if needed
                    _goals.Add(sg);
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;

                case "ChecklistGoal":
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);
                    var cg = new ChecklistGoal(name, description, points, target, bonus);
                    for (int j = 0; j < completed; j++) cg.RecordEvent();
                    _goals.Add(cg);
                    break;
            }
        }

        Console.WriteLine("Goals loaded.");
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Enter the number of the goal to record: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            Goal goal = _goals[index - 1];
            int beforeScore = _score;

            goal.RecordEvent();

            if (goal is SimpleGoal && goal.IsComplete())
                _goalsCompleted++;

            if (goal is ChecklistGoal && goal.IsComplete())
                _goalsCompleted++;

            _score += goal.Points;

            if (goal is ChecklistGoal cg)
            {
                if (cg.IsComplete())
                {
                    _score += cg.Points; // Add base points again (if not already in RecordEvent)
                    _score += cg.GetStringRepresentation().Contains("X") ? 0 : cg.Points;
                }
            }

            Console.WriteLine($"Total Score: {_score} | Level: {Level}");

            if (HasBadge && _goalsCompleted == 5)
                Console.WriteLine("🎖 Congratulations! You earned the 5-Goal Badge!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
}
