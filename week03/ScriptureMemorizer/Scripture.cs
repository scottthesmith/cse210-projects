using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
   private Reference _reference;
   List<Word> _words = new List<Word>();

   public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string [] splitText = text.Split(' ');
        foreach (string letter in splitText)
        {
            Word chosenWord = new Word(letter);
            _words.Add(chosenWord);
            
        
        }
    
    }
    public string GetDisplayText()
    {
        string finalScripture = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            finalScripture = finalScripture + " " + word.GetDisplayText();
        }
        return finalScripture;       
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomWord = new Random();
        int counter = 0;
        while (counter < numberToHide)
        {
            int index = randomWord.Next(_words.Count);
            Word word = _words[index];
            word.Hide();
            counter++;

        }
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = true;
        foreach (Word word in _words)
        {
            if IsHidden(Word)
            {
                allHidden = false;
            }
        }
        
    }

}