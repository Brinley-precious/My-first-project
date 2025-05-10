using System;

class Program
{
    static void Main(string[] args)
    
    {
        // Prompt for the first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Prompt for the last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Display the full name in the desired format
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}