using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class ListingActivity : Activity
{
    protected int _count = 0;
    protected List<string> _prompts = new List<string>
    {
        "Who are the people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"

    };
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");

        Random randomPrompt = new Random();
        string prompt = _prompts[randomPrompt.Next(_prompts.Count)];

        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        List<string> userItems = GetListFromUser(_duration);

        Console.WriteLine($"You listed {userItems.Count} items!");

        DisplayEndingMessage();
    }

    private List<string> GetListFromUser(int duration)
    {
        List<string> results = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                results.Add(input);            
            }
        }
        return results;
    }
}