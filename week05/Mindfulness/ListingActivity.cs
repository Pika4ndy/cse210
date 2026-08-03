public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _count;
    private List<string> _userList;
    private Random _random = new Random();
    public ListingActivity(List<string> prompts) : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = prompts;
        _userList = new List<string>();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get ready!...");
        ShowSpinner(3);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" ——— {GetRandomPrompt()} ———");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string userText = Console.ReadLine();

            if (!(userText.Trim() == ""))
            {
                _userList.Add(userText);
            }
        }
        
        _count = _userList.Count;

        Console.WriteLine($"You listed {_count} items\n");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int i = _random.Next(_prompts.Count);
        return _prompts[i];

    }

    public List<string> GetlistFromUser()
    {
        return _userList;
    }
}