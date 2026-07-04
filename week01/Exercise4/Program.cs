using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {   
        List<int> numbers = new List<int>();
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number = -1;
        
        while (number != 0)
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number !=0)
            {
                numbers.Add(number);
            }
        }
        
        int sum = 0;
        foreach (int digit in numbers)
        {
            sum += digit;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is {average}");


        int largest = numbers[0];
        foreach (int digit in numbers)
        {
            if (digit > largest)
            {
                largest = digit;
                
            }
        }
        Console.WriteLine($"The largest number is {largest}");
    }
}
