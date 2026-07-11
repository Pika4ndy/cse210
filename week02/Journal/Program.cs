// Journal Project

/* 
Program Description:
    This program simulates a command line journal that asks a prompt when the user
    wants to write in it so that he can find something to write. It uses the 
    principle of abstraction to make it simpler, understandable and manageable.

Classes overview:
    This program uses 3 different classes:
        - Journal: which is the main action class, it manages all the entries.
        - Entry: which create an entry instance containing the answered prompt,
        the date it was written and the entry text.

        - PromptGenerator: which can generate random prompts and manage all the prompts.

Exceeding requirements:
    - 'Remove entry' option
    - Allow the user to write paragraphs while writing an entry
    - Saved the 'user name' in the entry
    - Saved entries are stored in CSV files
*/

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        DateTime today = DateTime.Now;
        string username = "";

        int userInput = int.MaxValue; // Default value

        do
        {
            DisplayMenu();
            userInput = GetUserInput();

            switch (userInput)
            {
                case 0:
                break;

                case 1://Write in journal
                    string prompt = promptGenerator.GetRandomPrompt();
                    Entry newEntry = new Entry();
                    List<string> linesList = new List<string>();

                    while (username.Trim() == "")
                    {
                        Console.Write("Who is writing? ");
                        username = Console.ReadLine().Trim();
                    }

                    Console.WriteLine(prompt);
                    Console.WriteLine("[ Finish with an empty line to end entry ]");

                    string input;
                    do {
                        Console.Write("> ");
                        input = Console.ReadLine();
                        linesList.Add(input);
                    } while (input.Trim() != ""); 

                    newEntry._entryText = string.Join("\\n", linesList);
                    newEntry._entryText.Replace(";", "%semicolon%");
                    newEntry._date = today.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._username = username;

                    journal.AddEntry(newEntry);
                    Console.WriteLine();
                    break;

                case 2://Display journal
                    journal.DisplayAll();
                    break;

                case 3://Save journal in a file
                    Console.WriteLine("What is the filename without extension? (leave empty for default)");
                    string savingFileName = Console.ReadLine();

                    if (savingFileName.Trim() == "")
                    {
                        savingFileName = $"{today.Month}_{today.Day}_{today.Year}_journal";
                    }

                    journal.SavetoFile(savingFileName + ".csv");
                    break;

                case 4://Load journal from a file
                    Console.WriteLine("What is the filename without extension?");
                
                    string loadingFileName = Console.ReadLine();

                    bool isFilePresent = false;
                    
                    do
                    {
                        if (loadingFileName.Trim() == "")
                        {
                            loadingFileName = $"{today.Month}_{today.Day}_{today.Year}_journal";
                        }

                        try
                        {
                            isFilePresent = File.Exists(loadingFileName);
                            journal.LoadFromFile(loadingFileName + ".csv");
                            break;
                        }
                        catch (FileNotFoundException)
                        {
                            Console.Write($"The file {loadingFileName} doesn't exist, try again.\n-> ");
                            loadingFileName = Console.ReadLine();
                        }
                    } while (!isFilePresent);

                    if (username.Trim() == "")
                    {
                        username = journal._entries[0]._username;
                    }

                    break;

                case 5://Remove from journal
                    journal.DisplayAll();
                    Console.Write("Which entry would you like to remove (0 to remove all)? ");
                    string removeInput = Console.ReadLine();
                    int removeIndex = int.MaxValue;

                    bool parsed = int.TryParse(removeInput, out int ouput);
                    removeIndex = parsed ? ouput : -1;
                    
                    if (removeIndex > 0 && removeIndex <= journal._entries.Count)
                    {
                        journal.RemoveEntry(removeIndex - 1);
                    } else if (removeIndex == 0) {
                        journal._entries.RemoveAll(x => true);
                    } else
                    {
                        Console.WriteLine("Not valid: only valid index and 0 allowed");
                    }
                    break;

                default:
                    Console.WriteLine("I don't know, you shouldn't be here!");
                    break;
            }
        } while (userInput != 0);
    }

    static void DisplayMenu()
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Remove");
        Console.WriteLine("6. Quit");
        Console.Write("What would you like to do? ");
    }

    static int GetUserInput()
    {
        string userInput = Console.ReadLine().ToLower();

        switch (userInput)
        {
            case "1" or "write" or "w":
                return 1;

            case "2" or "display" or "d":
                return 2;

            case "3" or "save" or "s":
                return 3;

            case "4" or "load" or "l":
                return 4;

            case "5" or "remove" or "r":
                return 5;

            default:
                return 0;
        }
    }
}