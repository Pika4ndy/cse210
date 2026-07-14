using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is your lesson of the day?",
        "What's new you learnt today?"
    };

        Random _randomGenerator = new Random();


    public string GetRandomPrompt()
    {
        int randomIndex = _randomGenerator.Next(_prompts.Count);

        return _prompts[randomIndex];
    }
}