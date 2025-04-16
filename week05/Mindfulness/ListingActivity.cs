public class ListingActivity : Activity
{
    private int _count;
    protected List<string> _alist = new List<string>();
    private List<string> _prompts;
    public ListingActivity(string name, string description)
    {
        _name = name;
        _description = description;

        // populate the list of prompts
        _prompts = new List<string>(){
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

    }
    public void Run()
    {
        Console.WriteLine("You have chosen a listing exercise.");
        Console.WriteLine($"Name: {_name}  Description: {_description}");
        this.SetDuration(InitializeTimer());
        Console.WriteLine("\nPonder the following prompt. When the time expires, write a response.\n\n");
        this.GetRandomPrompt();
        Console.WriteLine("\n\n");
        if (_spinnerStyle == "spinner")
        {
            this.ShowSpinner(_duration);
        }
        else
        {
            this.ShowCountDown(_duration);
        }
    Console.WriteLine("Enter your listing activity comments.");
    string input = Console.ReadLine();
    Console.WriteLine($"You entered: {input}");
        this.GetListFromUser(input);
    }
    public void GetRandomPrompt()
    {
        Random _rnd = new Random();
        int _index = _rnd.Next(_prompts.Count());
        Console.WriteLine(_prompts[_index]);
    }
    public void GetListFromUser(string entry)
    {
        this._alist.Add(entry);

    }
}