using System;

public class Word
{
    // Given a word...//
    private string _text;
    private bool _isHidden = false;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    } 
    public Word(string text, bool hide)
    {
        _text = text;
        _isHidden = hide;
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
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            char blank_char = '_';
            int char_count = _text.Count();
            string blank_word = new string(blank_char, char_count);
            return blank_word;
        }
        else
        {
        return _text;
        }
    }
}