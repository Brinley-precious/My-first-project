using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts;
    private Random random;

    public PromptGenerator()
    {
        prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What made me laugh today?",
            "What challenge did I face today, and how did I handle it?"
        };

        random = new Random();
    }

    public string GetRandomPrompt()
    {
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
