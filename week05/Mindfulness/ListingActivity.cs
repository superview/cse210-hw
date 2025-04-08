public class ListingActivity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {
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

        foreach(string p in _prompts)
        {
            Console.WriteLine(p);
        }
    }
    public void Run()
    {

    }
    public void GetRandomPrompt()
    {

    }
    public List<string> GetListFromUser()
    {
        List<string> _alist = new List<string>();

        return _alist;
    }
}