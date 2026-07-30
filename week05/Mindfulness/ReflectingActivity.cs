public class ReflectingActivity : Activity
{
    Random _random = new Random();
    protected List<string> _prompts = new List<string>
    {
        "Think of a time when you successfully stood up for something you believed in.",
        "Think of a time when you helped someone else through a tough situation.",
        "Think of a time when you pushed through a really difficult obstacle.",
        "Think of a time when you turned a mistake into a learning opportunity.",
        "Think of a time when you were uplifted by another person.",
        "Think of a time when you took the time to teach someone."
    };
    protected List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself through this?",
        "How did you feel when it was complete?",
        "What steps did you take to get started?",
        "How can you apply what you learned to the future?",
        "Did it change your outlook on your life?",
        "Did this inspire you to change anything about yourself?"
    };

    protected List<string> _unusedPrompts = new List<string>();
    protected List<string> _unusedQuestions = new List<string>(); 

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        ResetPrompts();
        ResetQuestions();
    
    }

    public void ResetPrompts()
    {
        _unusedPrompts = new List<string>(_prompts);
    }
    public void ResetQuestions()
    {
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();

        Console.WriteLine("\nWhen you have something in mind, press Enter to continue");
        Console.ReadLine();
        
        Console.WriteLine("\nNow ponder on each of the following questions as related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();

        DisplayQuestions();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
    if (_unusedPrompts.Count == 0)
    {
        ResetPrompts();
    }
    int index = _random.Next(_unusedPrompts.Count);
    string prompt = _unusedPrompts[index];   
    _unusedPrompts.RemoveAt(index);
    return prompt;
    }

    public string GetRandomQuestion()
{
    if (_unusedQuestions.Count == 0)
    {
        ResetQuestions();
    }
    int index = _random.Next(_unusedQuestions.Count);
    string question = _unusedQuestions[index];   // pull from the same list you're tracking
    _unusedQuestions.RemoveAt(index);
    return question;
}
    public void DisplayPrompt()
    {
        Console.WriteLine($"=== {GetRandomPrompt()} ===");
    }

    public void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            
            Console.WriteLine($"=== {GetRandomQuestion()} ===");
            ShowCountdown(5);

        }
    }
}