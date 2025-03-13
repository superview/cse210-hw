using System;
// using System.Runtime.CompilerServices;
// using System.Security.Cryptography.X509Certificates;

public class Prompt
{
    private List<string> _prompts = new List<string> {
        "What did you do today?"
        , "What are you happy about today?"
        , "What are you sad about today?"
        , "What new thing did you learn about today?"
        , "What are you grateful for today?"
        , "Who did you lift up today?"
    };

    // Prompts constructor
    public Prompt()
    {
        Console.WriteLine($"Prompts constructor.");

    }

    public void Display()
    {
        Console.WriteLine("prompt display");

        // foreach... write prompt.
        foreach (string s in _prompts)
        {
            Console.WriteLine(s);
        }
    }
    public string GetRandom()
    {
        Console.WriteLine("Getting random string.");

        // Generate random index in the range of the _prompts list
        Random rand_number = new Random();
        int index = rand_number.Next(_prompts.Count);

        // Return the selected _prompt
        return _prompts[index];
    }
}