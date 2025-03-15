using System;
//using System.Collections.Generic;

public class Prompt
{
     public List<string> _prompts = new List<string>(){
        "What did you do today?"
        , "What am I happy about today?"
        , "What am I sad about today?"
        , "What new thing did I learn about today?"
        , "What am I grateful for today?"
        , "Who did I lift up today?"
        , "Write about an accomplishment that makes me happy."
        , "Who was the most interesting person I interacted with today?"
        , "What was the best part of my day?"
        , "How did I see the hand of the Lord in my life today?"
        , "What was the strongest emotion I felt today?"
        , "If I had one thing I could do over today, what would it be?"
    };
    public void AddPrompt(string prompt)
    {
        // string jabber = "yabbaDabbaDo!";
        _prompts.Add(prompt);
    }

    // Prompts constructor
    public Prompt()
    {
    }

    public void Display()
    {
        // foreach... write prompt.
        foreach (string s in _prompts)
        {
            Console.WriteLine(s);
        }
    }
    public string GetRandom()
    {
        // Return a randomly selected prompt
        // Generate random index in the range of the _prompts list
        Random rand_number = new Random();
        int index = rand_number.Next(_prompts.Count);

        // Return the selected _prompt
        return _prompts[index];
    }
}