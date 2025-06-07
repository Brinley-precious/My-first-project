using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base Assignment
        Assignment generalAssignment = new Assignment("Brinley Francis", "World History");
        Console.WriteLine(generalAssignment.GetSummary());
        Console.WriteLine();

        // Create a MathAssignment
        MathAssignment mathAssignment = new MathAssignment("Brinley Francis", "Algebra", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // Create a WritingAssignment
        WritingAssignment writingAssignment = new WritingAssignment("Brinley Francis", "English Literature", "Exploring Symbolism in Modern Poetry");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}