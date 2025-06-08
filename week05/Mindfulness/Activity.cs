using System;
using System.Collections.Generic;
using System.Threading;

// ===================== BASE CLASS =====================
public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected static Random _random = new Random();

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine(_description);
        Console.Write("Enter the duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        PerformActivity();
        Console.WriteLine($"\nGood job! You completed the {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    protected abstract void PerformActivity();

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i % spinner.Length]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
