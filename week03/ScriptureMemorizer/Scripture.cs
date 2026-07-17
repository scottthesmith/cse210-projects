using System.Runtime.InteropServices;

public class Scripture
{
   private Reference _reference;
   List<Word> _words = new List<Word>();

   public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
    }

}