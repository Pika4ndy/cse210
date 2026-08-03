using System.Diagnostics.CodeAnalysis;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random = new Random();

    public ReflectingActivity(List<string> prompts, List<string> questions) : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("Consider the Following prompt:");
        Console.WriteLine($"\n ——— {GetRandomPrompt()} ———");

        Console.WriteLine("\nWhen you have something in mind, press <Enter> to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of these following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();
        DisplayQuestions();
        Console.WriteLine();
        DisplayEndingMessage();

    }

    private void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        string currentQuestion = "";
        List<string> presentQuestions = new List<string>();

        while (DateTime.Now < endTime && presentQuestions.Count <= _questions.Count)
        {
            do 
            {
                currentQuestion = GetRandomQuestion();
            } while (presentQuestions.Contains(currentQuestion));

            presentQuestions.Add(currentQuestion);
            Console.Write($"> {currentQuestion} ");
            ShowSpinner(7);
            Console.WriteLine();
        }    
    }

    private string GetRandomPrompt()
    {

        int i = _random.Next(_prompts.Count);

        return _prompts[i];
    }

    private string GetRandomQuestion()
    {
        int i = _random.Next(_questions.Count);

        return _questions[i];
    }
}