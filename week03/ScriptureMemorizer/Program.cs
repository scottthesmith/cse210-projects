using System;
using System.Configuration.Assemblies;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference newReference = new Reference("John", 3, 16);
    
        Scripture chosenScripture = new Scripture(newReference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.WriteLine(chosenScripture.GetDisplayText());
    }
}