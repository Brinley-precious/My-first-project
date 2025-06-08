public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you’re grateful for:",
        "List as many people who inspire you:",
        "List your personal strengths:",
        "List goals you're proud to be working toward:"
    };

    private HashSet<int> _usedIndices = new HashSet<int>();

    public ListingActivity() : base("Listing Activity",
        "This activity helps you focus on the positive aspects of your life.")
    {
    }

    protected override void PerformActivity()
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
        Console.WriteLine("Start listing. Press Enter after each item.");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        int count = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items!");
    }
}