public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _completedCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _completedCount = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _completedCount++;
        if (_completedCount == _targetCount)
        {
            Console.WriteLine($"Goal complete! You earned {Points + _bonus} points!");
        }
        else
        {
            Console.WriteLine($"You earned {Points} points!");
        }
    }

    public override bool IsComplete()
    {
        return _completedCount >= _targetCount;
    }

    public override string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {Name} ({Description}) -- Completed: {_completedCount}/{_targetCount}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|{_bonus}|{_targetCount}|{_completedCount}";
    }
}
