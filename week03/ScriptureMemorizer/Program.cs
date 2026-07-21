// made it so that if a word is already hidden, a different non-hidden word will be hidden instead. 

class Program
{
    static void Main(string[] args)
    {
        Reference newReference = new Reference("John", 3, 16);

        Scripture chosenScripture = new Scripture(newReference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        string userChoice = "";
        while (userChoice != "quit" && chosenScripture.IsCompletelyHidden() == false)
        {
            Console.Clear();
            Console.WriteLine(chosenScripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide a random word, or type 'quit' to exit.");
            userChoice = Console.ReadLine();
            if (userChoice != "quit")
            {
                chosenScripture.HideRandomWords(1);
                if (chosenScripture.IsCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine(chosenScripture.GetDisplayText());
                    break;
                }
            }
    }
    }
}