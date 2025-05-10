using System;

class Program
{
    static void Main(string[] args)
    {
 // Ask user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

// Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Better luck next  time. Keep trying!");
        }
    }
}
