using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        List<int> numbers = new List<int>();
        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        }

        //  Compute average
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        Console.WriteLine($"The sum is: {total}");

        // Compute average
        float average = (float)total / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the largest number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}