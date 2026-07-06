using System;
using System.Net.Sockets;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int gradeAsInt = int.Parse(gradePercentage);
        string letterGrade = "";
        string gradeSign = "";
        int lastDigit = gradeAsInt % 10;
        
        // Percentage to letter grade conversion

        if (gradeAsInt >= 90)
        {
            letterGrade = "A";
        }
        else if (gradeAsInt >= 80)
        {
            letterGrade = "B";
        }
        else if (gradeAsInt >= 70)
        {
            letterGrade = "C";
        }
        else if (gradeAsInt >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        
        //Grade Signs

        if (lastDigit >=7)
        {
            gradeSign = "+";
        }
        else if (lastDigit <=3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }
        if (letterGrade == "F")
        {
            gradeSign = "";
        }
        if (gradeAsInt >= 97)
        {
            gradeSign ="";
        }

        // Print results

        Console.WriteLine($"Your grade is: {letterGrade}{gradeSign}");

        if (gradeAsInt >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("You can always try again!");

        }

    }
}