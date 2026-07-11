using System.IO;
using System.Security;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        int i = 0;
        if (_entries.Count <= 0)
        {
            Console.WriteLine("There are no entries yet.\n");
        } else {
            foreach (Entry entry in _entries)
            {
                i++;
                Console.Write($"{i}. ");
                entry.Display();
            }
        }
    }

    public void SavetoFile(string file)
    {
        using (StreamWriter outputfile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputfile.WriteLine($"{entry._date};{entry._promptText};{entry._entryText};{entry._username}");
            }
        }
        Console.WriteLine($"Entries saved in {file}");
    }

    public void LoadFromFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        
        List<Entry> loadedEntries = new List<Entry>();

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split(";");

            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entry._username = parts[3];

            loadedEntries.Add(entry);
        }

        _entries.AddRange(loadedEntries);
        Console.WriteLine("Entries successfully loaded.");
    }

    public void RemoveEntry(int entryIndex)
    {
        _entries.RemoveAt(entryIndex);
    }
}