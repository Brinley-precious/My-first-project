// Exceeds Requirements:
// 1. Leveling System: The user "levels up" every 1000 points, and their current level is displayed in the menu.
// 2. Badge Reward System: The user earns a special badge after completing 5 total goals. The badge is displayed in the menu.

// Program.cs
 using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        string input = "";

        while (input != "6")
        {
            Console.Clear();
            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine($"Score: {manager.Score} | Level: {manager.Level}");

            if (manager.HasBadge)
            {
                Console.WriteLine("🎖 Badge Earned: 5 Goals Completed!");
            }

            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.CreateGoal();
                    break;
                case "2":
                    manager.DisplayGoals();
                    break;
                case "3":
                    manager.SaveGoals();
                    break;
                case "4":
                    manager.LoadGoals();
                    break;
                case "5":
                    manager.RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}

                            