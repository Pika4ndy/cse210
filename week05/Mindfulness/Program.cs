// Week 5 Project: Mindfullness
/* 
Program Description:
    This program will help the user take time
    to make some mindfullness activities. There
    are 3 (original) kinds of activities: Breathing,
    reflecting, Listing. This program uses the principle
    of inheritance.

Eceeding requirements:
    - New Activity: Grounding Activity
        It brings the user to the present by using his physical senses

    - No-repeat of questions in the Reflecting Activity
    - History of all activity done during the session
    - Save & Load options of the history
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> reflectingPrompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            "Think of a time when you failed at something initially, but kept going anyway.",
            "Think of a time when you had to make a difficult choice between two hard options.",
            "Think of a time when someone went out of their way to support or encourage you."
        };

        List<string> reflectingQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
            "What strengths or internal resources did you draw upon during this experience?",
            "Who supported you during this process, and how did their support impact you?",
            "In what ways did this experience surprise you?"
        };

        List<string> listingPrompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "What are some challenges or obstacles you have successfully overcome?",
            "What are small things in your daily routine that bring you peace or comfort?",
            "Who are people in your life that you know you can rely on?"
        };


        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity(reflectingPrompts, reflectingQuestions);
        ListingActivity listingActivity = new ListingActivity(listingPrompts);
        GroundingActivity groundingActivity = new GroundingActivity();

        ActivityHistory history = new ActivityHistory();

        string userInput = DisplayMenu().ToLower().Trim();

        string[] breathingOptions = { "1", "breathing", "b" };
        string[] reflectingOptions = { "2", "reflecting", "r" };
        string[] listingOptions = { "3", "listing", "l" };
        string[] groundingOptions = { "4", "grounding", "g" };
        string[] historyOptions = { "5", "history"};
        string[] saveOptions = { "6", "save"};
        string[] loadOptions = { "7", "load"};
        string[] quitOptions = { "8", "quit", "q"};

        while (!quitOptions.Contains(userInput))
        {
            if (breathingOptions.Contains(userInput)) // Breathing Activity
            {
                breathingActivity.Run();
                history.Track(breathingActivity);
            }
            else if (reflectingOptions.Contains(userInput)) // Reflecting Activity
            {
                reflectingActivity.Run();
                history.Track(reflectingActivity);
            }
            else if (listingOptions.Contains(userInput)) // Listing Activity
            {
                listingActivity.Run();
                history.Track(listingActivity);
            }
            else if (groundingOptions.Contains(userInput)) // Grounding Activity
            {
                groundingActivity.Run();
                history.Track(groundingActivity);
            }
            else if (historyOptions.Contains(userInput)) // Show history
            {
                history.ShowHistory();
            }
            else if (saveOptions.Contains(userInput)) // Save history to a file
            {
                Console.Clear();
                Console.WriteLine("Saving History...");

                Console.WriteLine("What is the name of the file?");
                string filename = Console.ReadLine();
                history.SaveHistory(filename);
            }
            else if (loadOptions.Contains(userInput))
            {
                Console.Clear();
                Console.WriteLine("Loading history...");
                Console.WriteLine("What is the name of the file?"); // Load history from a file
                string filename = Console.ReadLine();
                history.LoadHistory(filename);
            }
            else
            {
                break;
            }

            userInput = DisplayMenu();
        }
    }

    static string DisplayMenu()
    {
        List<string> menuList = new List<string>
        {
            "Start Breathing Activity",
            "Start Reflecting Activity",
            "Start Listing Activity",
            "Start Grounding Activity",
            "Show History",
            "Save Activity History",
            "Load Activity History",
            "Quit"
        };

        Console.Clear();
        Console.WriteLine("Menu options:");

        for (int i = 0; i < menuList.Count; i++)
        {
            Console.WriteLine($"\t{i+1}. {menuList[i]}");
        }

        Console.Write("Select a choice from menu: ");
        return Console.ReadLine();
    }
}