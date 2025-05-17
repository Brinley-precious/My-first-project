using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Console.Write("Your mood: ");
                    string mood = Console.ReadLine();

                    Entry newEntry = new Entry(prompt, response, mood);
                    journal.AddEntry(newEntry);
                    break;

                case "2":
                    Console.WriteLine("\nYour Journal Entries:");
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("Enter the filename to save to (e.g., journal.csv): ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter the filename to load from (e.g., journal.csv): ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose 1-5.");
                    break;
            }
        }
         // Exceeds requirement: 
         // 1. Added mood tracking to each journal entry.
         // 2. Implemented CSV file formatting with proper handling of commas/quotes for Excel compatibility.

    }
}
