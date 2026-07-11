public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What was the best part of my day?",
        "Who was the most interesting person I talked to today?",
        "What is the one thing I wish I did differently today?",
        "What do I regret not doing today?",
        "What can I improve on tomorrow?",
        "What was the nicest thing someone said to me today?",
        "What was the nicest thing I said to someone today?",
        "Did I lighten anyone's burden today?"

    
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        
            int index = random.Next(_prompts.Count);
            string chosenPrompt = _prompts[index];
            return chosenPrompt;
    }



}