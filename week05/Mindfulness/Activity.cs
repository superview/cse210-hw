using System.ComponentModel.DataAnnotations;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the start.");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Good job completing");
    }
    public void ShowSpinner(int seconds)
    {
        int _spin_chars = 0; // pointer to the spin array (list)
        _duration = seconds; // How long to run the spinner
        int _delay = 1000; // miliseconds wait delay
        // Console.WriteLine($"Duration: {_duration}, delay:{_delay}, {_duration * _delay}");
        List<string> _spinner = new List<string>();
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        _spinner.Add("\\");
        _spinner.Add("|");
        _spinner.Add("/");
        _spinner.Add("-");
        for(int i = 0; i<_duration; i++)
        {
            if(_spin_chars > 6){_spin_chars = 0;}
            Thread.Sleep(_delay);
            Console.Write($"\r         {_spinner[_spin_chars]}         ");
            _spin_chars += 1;
        }
    }
    public void ShowCountDown(int seconds)
    {

        for(int i = seconds; i >=0; i--)
        {
            Console.Write($"\r     Minutes:seconds {i/60}:{i % 60}         ");
            Thread.Sleep(1000);
        }
        // clear line
        Console.WriteLine("\r                                                  ");
    }
}