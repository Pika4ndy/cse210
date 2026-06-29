// Basic syntax of C#: Bond, James Bond
/* 
Code description:
    This program will diplay a James Bond like presentation after asking the user for
    his first name and last name and then output as the following structure:

        Your name is [last name], [first name] [last name]
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.Beep();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
        
    }
}