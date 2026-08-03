// This class will manage the exportation and Data of each mindfullness session
using System.IO;
public class ActivityHistory
{
    private List<List<string>> _history = new List<List<string>>();
    private const string _separator = "~|~";

    public ActivityHistory()
    {
        
    }

    public void Track(Activity activity)
    {
        List<string> activityInfo = new List<string>
        {
            DateTime.Now.ToShortDateString(),
            activity.GetName(),
            activity.GetDuration().ToString() + "s"
        };

        _history.Add(activityInfo);
    }

    public void SaveHistory(string filename)
    {
        using (StreamWriter outputfile = new StreamWriter(filename, append: true))
        {
            foreach (List<string> item in _history)
            {
                outputfile.WriteLine(string.Join(_separator, item));
            }
        }
    }

    public void LoadHistory(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"Sorry, '{filename}' could not be found. Press <Enter> to continue");
            Console.ReadLine();
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(_separator);
            List<string> partslist = parts.ToList();
            _history.Add(partslist);
        }
    }

    public List<List<string>> GetHistory()
    {
        return _history;
    }

    public void ShowHistory()
    {
        Console.Clear();
        if (_history.Count > 0)
        {
            foreach (List<string> line in _history)
            {
                Console.WriteLine(string.Join(", ", line));
            }
        } else
        {
            Console.WriteLine("There is nothing yet!");
        }
        Console.WriteLine("\nPress <Enter> to return to menu");
        Console.ReadLine();
    }
}