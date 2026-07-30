using System.ComponentModel;
using System.Reflection;

public class BreathingActivity : Activity
{
   
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {
    
    }
    public void Run()
    {
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in... ");
            ShowCountdown(5);

            if (DateTime.Now >= endTime) break;

            Console.WriteLine();
            Console.WriteLine("Now breathe out... ");
            ShowCountdown(5);

        }

        DisplayEndingMessage();

    
    }

}