using System;

public class Word
{
    // Given a word...//
    private bool _isHidden = false;
    private string _word;
    public Word(string word)
    {
        _word = word;
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
            int char_count = _word.Count();
            string blank_word = new string(blank_char, char_count);
            return blank_word;
        }
        else
        {
        return _word;
        }
    }
}