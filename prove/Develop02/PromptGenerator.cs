using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _questions = new List<string>()
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you could do one thing over today, what would it be?",
        "What was the most significant moment of your day?",
        "Which achievement made you feel the most proud today?",
        "When did you feel the most gratitude?",
        "What was the most valuable lesson you learned today?",
        "What small act of kindness did you perform for someone else?"
    };

    public string PromptQuestion()
    {
        int size = _questions.Count;
        Random rnd = new Random();
        int randIndex = rnd.Next(size);
        string random = _questions[randIndex];
        Console.WriteLine(random);
        
        return random;
    }
}