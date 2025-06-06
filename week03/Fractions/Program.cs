using System;

class Program
{
    static void Main(string[] args)
    {
        // Default constructor
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());   
        Console.WriteLine(f1.GetDecimalValue());    

        // One-parameter constructor
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());   
        Console.WriteLine(f2.GetDecimalValue());     

        // Two-parameter constructor
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());   
        Console.WriteLine(f3.GetDecimalValue());     

        // Another two-parameter
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());     
    }
}