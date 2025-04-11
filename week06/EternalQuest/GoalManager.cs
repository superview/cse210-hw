public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    public GoalManager()
    {

    }
    public void Start()
    {

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
                    Console.WriteLine("\nEnter the type of goal you would like to add:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    ConsoleKeyInfo _inner_choice = Console.ReadKey(true);

                    Console.Clear();
                    Console.WriteLine($"You chose option key: {_inner_choice.KeyChar}");
                    switch (_inner_choice.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                        case ConsoleKey.S:
                        Console.WriteLine($"New Simple Goal");
                        Console.WriteLine($"Enter a new Simple Goal name: ");
                        string _inputName = Console.ReadLine();
                        Console.WriteLine($"Enter a description: ");
                        string _inputDescription = Console.ReadLine();
                        Console.WriteLine($"Enter number of points: ");
                        string _inputPoints = Console.ReadLine();
                        SimpleGoal _sg = new SimpleGoal(_inputName, _inputDescription, _inputPoints);
                        _goals.Add(_sg);
                        Console.WriteLine(_sg.GetDetailsString());
                        Console.WriteLine(_sg.GetStringRepresentation());
                        break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                        case ConsoleKey.E:
                        Console.WriteLine($"New Eternal Goal");
                        Console.WriteLine($"Enter a new Eternal Goal name: ");
                        string _inputEgName = Console.ReadLine();
                        Console.WriteLine($"Enter a description: ");
                        string _inputEgDescription = Console.ReadLine();
                        Console.WriteLine($"Enter number of points: ");
                        string _inputEgPoints = Console.ReadLine();
                        EternalGoal _eg = new EternalGoal(_inputEgName, _inputEgDescription, _inputEgPoints);
                        _goals.Add(_eg);
                        Console.WriteLine(_eg.GetDetailsString());
                        Console.WriteLine(_eg.GetStringRepresentation());
                        break;
                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                        case ConsoleKey.C:

                        Console.WriteLine($"New Checklist Goal");
                        Console.WriteLine($"Enter a new Checklist Goal name: ");
                        string _inputCgName = Console.ReadLine();
                        Console.WriteLine($"Enter a description: ");
                        string _inputCgDescription = Console.ReadLine();
                        Console.WriteLine($"Enter number of points: ");
                        string _inputCgPoints = Console.ReadLine();
                        ChecklistGoal _cg = new ChecklistGoal(_inputCgName, _inputCgDescription, _inputCgPoints,1,4);
                        _goals.Add(_cg);
                        Console.WriteLine(_cg.GetDetailsString());
                        Console.WriteLine(_cg.GetStringRepresentation());
                        break;

                        default:
                            Console.WriteLine("Something went wrong. Please try again");
                        break;
                    }

                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                case ConsoleKey.L:
                    // List all goals
                    int _counter = 1;
                    foreach (Goal gg in _goals)
                    {
                        Console.WriteLine($"\n----- Goal Entry {_counter++} --------------");
                        Console.WriteLine($"Name: {gg.GetName()}");
                        Console.WriteLine($"Description: {gg.GetDescription()}");
                        Console.WriteLine($"Points: {gg.GetPoints()}");

                    }
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