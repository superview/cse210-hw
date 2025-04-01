using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class Scripture
{
    // private Reference _reference { get; set; } = new("boooook",3,24);
    private Reference _reference = new();
    // private Reference _reference = new("boooook",3,24);
    private List<Word> Words { get; set; } = new List<Word>();
    public int visible_words;
    public Scripture(Reference ref1, string text)
    {
        _reference = ref1;

        // add words using the word object
        foreach(string w in text.Split())
        {
            Words.Add(new Word(w, false));
        }
        visible_words = Words.Count;
    }

    public void HideRandomWords()
    {
        Random rand = new Random();
        int selected = rand.Next(0, Words.Count);
        bool loop_condition = true;
        while(loop_condition)
        {
            selected = rand.Next(0, Words.Count);
            if(! Words[selected].IsHidden())
            {
                Words[selected].Hide();
                visible_words --;
                loop_condition = false;
                Console.WriteLine($"This is the number of visible: {visible_words}");
            }
        }

    }

    public string GetDisplayText()
    {
        return "string";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }

    public void DisplayAll()
    {
        Console.WriteLine("------------------------------------------\n");
        Console.WriteLine($"Reference: {_reference.DisplayAll()}");
        foreach (Word w in Words)
        {
            Console.Write($"{w.GetDisplayText()} ");
        }
        // Write line after quote
        Console.WriteLine("\n");
    }
    
    public int GetRandomScripture(int count)
        {
            Random rand = new Random();
            int selected = rand.Next(0, count);
            return selected;
        }

}