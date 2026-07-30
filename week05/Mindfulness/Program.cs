using System;
using System.Runtime.Intrinsics.X86;
// Made it so that the questions in the Reflecting activity won't be duplicated until each question has been asked, and 
//created a counter that displays how many exercises you completed for that run.
class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";
        int sessionsCompleted = 0;
        

        while (userChoice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.WriteLine($"You have completed a total of {sessionsCompleted} sessions this run.");

            Console.WriteLine("Select a choice from the menu: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                //Console.WriteLine("Breathing activity is now loading");
                //Thread.Sleep(2000);
                BreathingActivity b1 = new BreathingActivity();
                {
                    b1.Run();
                    sessionsCompleted++;
                }
                
            }
            else if (userChoice == "2")
            {
                //Console.WriteLine("Reflecting activity is now loading");
                //Thread.Sleep(2000);
                ReflectingActivity r1 = new ReflectingActivity();
                {
                    r1.Run();
                    sessionsCompleted++;
                }
            }
            else if (userChoice == "3")
            {
                //Console.WriteLine("Listing activity is now loading");
                //Thread.Sleep(2000);
                ListingActivity l1 = new ListingActivity();
                {
                    l1.Run();
                    sessionsCompleted++;
                }
            }
           
        }

        
    }
}