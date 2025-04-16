public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, string style = "spinner")
    {
        _name = name;
        _description = description;
    }
    public void Run()
    {
        Console.WriteLine("You have chosen a breathing exercise. Breath in and out until the time expires.");
        Console.WriteLine($"Name: {_name}  Description: {_description}");
        if (_spinnerStyle == "spinner")
        {
            this.ShowSpinner(_duration);
        }
        else
        {

            this.ShowCountDown(_duration);
        }
    }
}