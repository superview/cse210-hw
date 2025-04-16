public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, string style)
    {
        _name = name;
        _description = description;
        _spinnerStyle = style;
        _prompts = [
            "What was your favorite thing to happen today?",
            "Who did you help today?",
            "What one thing did you give to help another?",
            "How can you find someone to help out?"
        ];

    }
    public void Run()
    {
        ShowRandomPrompt();
        if (_spinnerStyle == "spinner")
        {
            this.ShowSpinner(_duration);
        }
        else
        {
            this.ShowCountDown(_duration);
        }

    }
    public void ShowRandomPrompt()
    {
        Random rand = new Random();
        Console.WriteLine($"{_prompts[rand.Next(_prompts.Count())]}");
    }
    public string GetRandomQuestion()
    {
        return "question";
    }
    public void DisplayPrompt()
    {

    }
    public void DisplayQuestion()
    {

    }
}