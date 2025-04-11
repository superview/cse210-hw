public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {

    }
    public void Start()
    {
        EternalGoal _eg = new EternalGoal("EGoal","This is a goal.", "12");
        Console.WriteLine("Menu Loop");
        Console.WriteLine(_eg.GetDetailsString());
        Console.WriteLine(_eg.GetStringRepresentation());


        // Present menu and get action from user
        Boolean _loop = true;
        Console.WriteLine($"\nWelcome to your Goals with Goal Quest!");
        while (_loop)
        {
            Console.WriteLine($"Please select from the following actions: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter a number: ");
            
            ConsoleKeyInfo choice = Console.ReadKey(true);
            Console.Clear();

            Console.WriteLine($"You chose option key: {choice.KeyChar}");
            // Get user choice from cl menu
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                case ConsoleKey.N:
                    // Create new goal
                    // j.AddEntry();

                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                case ConsoleKey.L:
                        // List all goals
                        // foreach (Entry je in j.entries)
                        // {
                            // Console.WriteLine("\n----- Entry --------------");
                            // Console.WriteLine($"Date: {je._created.ToShortDateString()}    Prompt: {je._prompt}\nEntry:   {je._entry}");
                        // }
                        break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                case ConsoleKey.O:
                        // List all goals
                        // Save Goals
                        // file = "journal.json"; // save location
                        // either one of the following works to save the file
                        // SaveToFile(j,file);
                        // j.Save(file);
                        
                        break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                case ConsoleKey.A:
                        // Load Goals
                        // j.Load(file);
                        break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Console.WriteLine("Record Event");
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                case ConsoleKey.Q:
                    Console.WriteLine("Exiting.");
                    _loop = false;
                    break;
                default:
                    Console.WriteLine("Something went wrong. Please try again");
                    break;
                }
            };

        }

    // static void SaveToFile(Journal j, string file)
    // {
        // string jsonString = JsonSerializer.Serialize(j.entries, new JsonSerializerOptions {WriteIndented = true});
        // File.WriteAllText(file, jsonString);
        // Console.WriteLine(jsonString);
    // }



    public void DisplayPlayerfInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }

}