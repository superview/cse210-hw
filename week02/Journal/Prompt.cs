using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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
    }
    public string GetRandom()
    {
        Console.WriteLine("Getting random string.");
        Random rand_number = new Random();
        int index = rand_number.Next(_prompts.Count);

        return _prompts[index];
    }
}