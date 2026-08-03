
using System.Data.SqlTypes;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    

    public Activity()
    {
        
    }    
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like this session to last?");
        
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done. Hopefully these exercises have helped you to relax and appreciate how great you are.");
        ShowSpinner(3);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(8);
    
    }
    public void ShowSpinner(int seconds)
    {
        List<string>timeAnimation = new List<string>();
        timeAnimation.Add("|");
        timeAnimation.Add("/");
        timeAnimation.Add("-");
        timeAnimation.Add("\\");

        int indexTracker = 0;

        DateTime currentTime = DateTime.Now;

        DateTime endTime = currentTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(timeAnimation[indexTracker]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            indexTracker++;
            if (indexTracker >= timeAnimation.Count)
            {
                indexTracker = 0;
            }
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
