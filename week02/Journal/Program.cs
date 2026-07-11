// Created 8 prompts. Improved entry presentation/readability with visual separators.

using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal newJournal = new Journal();
    
        
        PromptGenerator newPrompt = new PromptGenerator();

        bool journalingIsFun = true;

        while (journalingIsFun)
        {
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.WriteLine("Please choose an option.");
            int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    string promptText = newPrompt.GetRandomPrompt();
                    Console.WriteLine(promptText);
                    string userResponse = Console.ReadLine();
                    Entry latestEntry = new Entry();
                    latestEntry._date = dateText;
                    latestEntry._prompt = promptText;
                    latestEntry._userEntry = userResponse;
                    newJournal.AddEntry(latestEntry);

        
                }
                if (userChoice == 2)
                {
                    newJournal.DisplayAll();
                }
                if (userChoice == 3)
                {
                    Console.WriteLine("What is the filename?");
                    string loadFile = Console.ReadLine();
                    newJournal.LoadFromFile(loadFile);
                }
                if (userChoice == 4)
                {
                    Console.WriteLine("What is the filename?");
                    string saveFile = Console.ReadLine();
                    newJournal.SaveToFile(saveFile);
                    
                    
                }
                if (userChoice == 5)
                {
                    journalingIsFun = false;
                }
            
            
        }
           
    }
    

    // Classes needed: Program - This is where you will create your journal entries, Journal - contains all of the entries previously created. Can call the entry class to display each entry, Entry, PRomptGenerator

    // Journal member variables should be entries

    // Entry member variables - Date, prompt used, user's entry

    // PromptGenerator member variables - List of prompts that can be randomly selected and given to the users
    

    

}