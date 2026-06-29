// Loop Statement: Guess My Number
/* 
Program Description:
    This program will run a 'guess my number' game while giving clues to the user if the number is higher or lower.
 */
using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();

        bool wantToPlay = true;
        
        do
        {
            int chosenNumber = randomGenerator.Next(1, 100);

            int guessedNumber = 0;


            while (guessedNumber != chosenNumber)
            {
                Console.Write("Guess my number: ");
                string userInput = Console.ReadLine();

                guessedNumber = int.Parse(userInput);

                if (guessedNumber == chosenNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                else if (guessedNumber > chosenNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }

            }
            Console.Write("Do you want to continue playing? ");

            string continuePlaying = Console.ReadLine().ToLower();

            if (!(continuePlaying == "yes" || continuePlaying == "y"))
            {
                wantToPlay = false;
            }
        
        } while (wantToPlay);
    }
}