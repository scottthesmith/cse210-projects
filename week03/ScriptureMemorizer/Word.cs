

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
         _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
       _isHidden = false;
    }
    public bool IsHidden()
    {
        if (_isHidden )
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            int _missingText = _text.Length;
            return new string('_',_missingText);
            
            
            
        }
        else
        {
            return _text;
        }
    }
  


}