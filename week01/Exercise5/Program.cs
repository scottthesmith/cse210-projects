using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        Console.WriteLine($"Welcome {userName}, the square of your favorite number is {squareNumber}");
    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the progam!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favNumber = int.Parse(Console.ReadLine());
        return favNumber;
    }
    static int SquareNumber(int favNumber)
    {
        int square = favNumber * favNumber;
        return square;
    }
}