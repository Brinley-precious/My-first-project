public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you overcame a challenge.",
        "Recall a moment of peace you've experienced.",
        "Think of a time you helped someone in need.",
        "Remember a time you felt truly accomplished."
    };

    private HashSet<int> _usedIndices = new HashSet<int>();

    public ReflectingActivity() : base("Reflecting Activity",
        "This activity will help you reflect on meaningful moments.")
    {
    }

    protected override void PerformActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (_usedIndices.Count == _prompts.Count)
            {
                _usedIndices.Clear();
            }

            int index;
            do
            {
                index = _random.Next(_prompts.Count);
            } while (_usedIndices.Contains(index));

            _usedIndices.Add(index);

            Console.WriteLine($"\n{_prompts[index]}");
            ShowSpinner(5);
        }
    }
}