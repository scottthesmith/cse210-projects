using System;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // ****** While Loop Example:********
        //string response = "yes";

        //while (response == "yes")
        // {
            //Console.Write("Do you want to continue? ");
            //response = Console.ReadLine();
        // }
        //****** Do-While Loop Example: ***********
        // string response;

        // do
        // {
            // Console.Write("Do you want to continue? ");
            // response = Console.ReadLine();
        // } while (response == "yes");

        // *******
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,11);
    

        int numberGuess = -1;
        Console.WriteLine("");
        Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess it?");

        while (numberGuess != magicNumber)
        {
            Console.WriteLine("");
            Console.WriteLine("What's your guess?");
            Console.WriteLine("");
            numberGuess = int.Parse(Console.ReadLine());

            if (numberGuess == magicNumber)
            {
                Console.WriteLine("");
                Console.WriteLine($"You guessed it! The number was {magicNumber}.");
                Console.WriteLine("");
            }
            else if (numberGuess > magicNumber)
            {
                Console.WriteLine("");
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Higher");
            }
        }
    }
}