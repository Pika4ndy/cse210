public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name}");
        Console.WriteLine($"\n{_description}");
        Console.Write($"\nHow long, in seconds, would you like for this session? ");

        _duration = 0;
        while (_duration == 0)
        {
            try
            {
                _duration = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {

                Console.WriteLine("Please enter a non-zero number!");
                Console.Write("-> ");
            }

        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!");
        ShowSpinner(2);
        Console.WriteLine($"\nYou have completed {_duration}s of {_name}");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        do
        {
            List<string> spinner = new List<string> { "|", "/", "—", "\\", "|", "/", "—", "\\" };

            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        } while (DateTime.Now < endTime);
    }

    public void ShowCountdown(int seconds)
    {

        for (int second = seconds; second > 0; second--)
        {
            Console.Write(second);
            Thread.Sleep(1000);
            if (10 <= second)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }
    public int GetDuration()
    {
        return _duration;
    }

    public string GetName()
    {
        return _name;
    }
}