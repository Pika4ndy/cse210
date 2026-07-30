using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment homework = new Assignment("Joe Doe", "Multiplication");

        Console.WriteLine(homework.GetSummary());

        MathAssignment mathHomework = new MathAssignment("Clara Goldberg", "Integrals", "7.1", "8-10, 15");

        Console.WriteLine();
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());

        WritingAssignment historyHomework = new WritingAssignment("Sonic Hegdehog", "History", "World War II");

        Console.WriteLine();
        Console.WriteLine(historyHomework.GetSummary());
        Console.WriteLine(historyHomework.GetWritingInformation());
    }
}