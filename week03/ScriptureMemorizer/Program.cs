using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") break;

            if (!scripture.IsCompletelyHidden())
                scripture.HideRandomWords();
            else
                break;
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words hidden. Program complete.");
    }
}
// EXCEEDED REQUIREMENTS:
// 1. Scripture words are only hidden if not already hidden.
// 2. Program ends automatically when all words are hidden.
// 3. Used List<Word> and LINQ to dynamically manage which words to hide, etc.