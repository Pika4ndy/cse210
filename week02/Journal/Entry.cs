public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _username; 
    public void Display()
    {
        Console.WriteLine($"Date: {_date} by {_username} — Prompt: {_promptText}\n{_entryText.Replace("\\n", Environment.NewLine).Replace("%semicolon%", ";")}");
    }
}