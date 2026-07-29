using System.ComponentModel;
using System.Diagnostics.Contracts;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, int duration, string description )
    {
        _name = name;
        _duration = duration;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the mindfulness program");
    }
    public void DisplayEndingMessage()
    {
    
    }

    public void ShowSpinner(int seconds)
    {

    }

    public void ShowCountdown(int second)
    {
        
    }
}
