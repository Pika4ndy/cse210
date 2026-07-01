// Lists & Generics: numbers statistic

/* 
Program Description:
    This program will ask a number to the user repeatedly until he inputs 0
    Then it will display data about it like:
        - sum of all numbers
        - the average
        - the highest number
        - the lowest positive number
        - a new sorted list of the numbers
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<float> userNumberList = new List<float>();
        float userNumber = 1;

        do
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            userNumber = float.Parse(userInput);

            userNumberList.Add(userNumber);
            
            
        } while (userNumber != 0);

        userNumberList.Remove(0);

        userNumberList = userNumberList.DefaultIfEmpty(0).ToList();

        float numbersSum = userNumberList.Sum();

        float average = userNumberList.Average();

        float highestNumber = userNumberList.Max();
        float lowestPositive = userNumberList.Where(x => x > 0).DefaultIfEmpty(0).Min();

        userNumberList.Sort();

        Console.WriteLine($"The sum of all numbers is: {numbersSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The highest number is: {highestNumber}");
        Console.WriteLine($"The lowest positive number is: {lowestPositive}");
        Console.WriteLine($"The sorted list is:");
                
        foreach (int number in userNumberList)
        {
            Console.WriteLine(number);
        }
    }
}