public class BreathingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Breathe in slowly through your nose...",
        "Hold your breath...",
        "Exhale slowly through your mouth..."
    };

    private int _promptIndex = 0;

    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by guiding your breathing.")
    {
        ShufflePrompts();
    }

    protected override void PerformActivity()
    {
        int cycleTime = 6; // 3s in, 3s out
        int cycles = _duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            foreach (string prompt in _prompts)
            {
                Console.WriteLine(prompt);
                Countdown(3);
            }
        }
    }

    private void ShufflePrompts()
    {
        for (int i = _prompts.Count - 1; i > 0; i--)
        {
            int j = _random.Next(i + 1);
            var temp = _prompts[i];
            _prompts[i] = _prompts[j];
            _prompts[j] = temp;
        }
    }
}