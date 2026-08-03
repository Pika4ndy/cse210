public class GroundingActivity : Activity
{
    public GroundingActivity() : base("Grounding Activity", "This activity will help you focus on your surroundings and keep track of your sense.")
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);

        int timePerStep = Math.Max(1, GetDuration() / 5);


        Console.Write($"\nThink of 5 thing(s) you can SEE ");
        ShowSpinner(timePerStep);

        Console.Write($"\nThink of 4 thing(s) you can TOUCH/FEEL ");
        ShowSpinner(timePerStep);

        Console.Write($"\nThink of 3 thing(s) you can HEAR ");
        ShowSpinner(timePerStep);

        Console.Write($"\nThink of 2 thing(s) you can SMELL ");
        ShowSpinner(timePerStep);

        Console.Write($"\nThink of 1 thing(s) you can TASTE ");
        ShowSpinner(timePerStep);

        Console.WriteLine("\n");
        DisplayEndingMessage();
    }
}