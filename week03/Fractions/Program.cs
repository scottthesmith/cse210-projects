using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
    Fraction f1 = new Fraction(1,1);
    Console.WriteLine(f1.GetFractionString());
    Fraction f2 = new Fraction(1);
    Console.WriteLine(f2.GetDecimalValue());
    Fraction f3 = new Fraction(5);
    Console.WriteLine(f3.GetFractionString());
    Fraction f4 = new Fraction(5);
    Console.WriteLine(f4.GetDecimalValue());
    Fraction f5 = new Fraction(3,4);
    Console.WriteLine(f5.GetFractionString());
    Fraction f6 = new Fraction(3,4);
    Console.WriteLine(f6.GetDecimalValue());
    Fraction f7 = new Fraction(1,3);
    Console.WriteLine(f7.GetFractionString());
    Fraction f8 = new Fraction(1,3);
    Console.WriteLine(f8.GetDecimalValue());

    

        
    }
}