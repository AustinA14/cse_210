using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What made me smile today?",
        "If I could do one thing different today, what would it be?",
        "How did I see the hand of the Lord in my life today?",
        "What is one new thing to be grateful for after today?",
        "Who's life did I touch in a positive way today?",
        "Who touched my life in a positive way today?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}