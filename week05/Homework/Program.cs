using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Scott Smith", "Divination");
        string name = a1.GetSummary();
        Console.WriteLine(name);
        MathAssignment m1 = new MathAssignment("Yummy Tommy", "fractions", "5.4", "15-25");
        Console.WriteLine(m1.GetSummary());
        Console.WriteLine(m1.GetHomeworkList());

        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History","The Causes of World War II");
        Console.WriteLine(w1.GetSummary());
        Console.WriteLine(w1.GetWritingInformation());
    
    }
}



