// if statements: Number grade to letter grade
/* 
Program Description:
    This program will display the letter grade according to the number grade inputted
    It works by using conditions to verify if the number grade is greater or less than
    a certain point.

*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade? -> ");

        bool isPassing = true;

        string grade = Console.ReadLine();

        int gradeInt = int.Parse(grade);

        string gradeLetter= "";

        if (gradeInt >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeInt >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeInt >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeInt >= 60)
        {
            gradeLetter = "D";
            isPassing = false;
        }
        else
        {
            gradeLetter = "F";
            isPassing = false;
        }

        int lastDigit = gradeInt % 10;


        if (lastDigit >= 7 && gradeLetter != "A" && gradeLetter != "F")
        {
            gradeLetter += "+";
        }
        else if (lastDigit < 3 && gradeLetter != "F")
        {
            gradeLetter += "-";
        }

        Console.WriteLine($"The grade is {gradeLetter}");


        if (isPassing)
        {
            Console.WriteLine("Congratulations! You have passed.");
        }
        else
        {
            Console.WriteLine("I am sorry, you have not passed.");
        }
    }
}