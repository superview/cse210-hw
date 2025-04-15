using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace EternalQuest
{


    public class GoalManager
    {
        // public List<Goal> _goals {get; set;} = new List<Goal>();
        public List<Goal> _eGoals = new List<Goal>();
        // public List<EternalGoal> _eGoals = [];
        // public List<EternalGoal> _eGoals {get; set;} = [];
        private int _score;
        private string _file = "goals.json"; // save location
        private int _totalPoints = 0; // total points collected from completed goals
        public GoalManager()
        {

        }
        public void Start()
        {

            // Present menu and get action from user
            Boolean _loop = true;
            Console.WriteLine($"\nWelcome to your Goals with Goal Quest!");
            if (File.Exists(_file))
            {
                this.LoadGoals(_file);
            }
            Console.Clear();

            while (_loop)
            {
                Console.WriteLine($"Please select from the following actions: ");
                Console.WriteLine("1. Create New Goal");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Display Player Information");
                Console.WriteLine("7. Quit");
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
                        this.CreateGoal();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.L:
                        // List all goals
                        ListGoalNames();
                        ListGoalDetails();
                        ListAllGoals();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.O:
                        // Save Goals
                        this.SaveGoals(_file);

                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.A:
                        // Load Goals
                        LoadGoals(_file);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        Console.WriteLine("Record Event");
                        ListGoalNames();
                        RecordEvent();
                        // stub

                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.D:
                        DisplayPlayerfInfo();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                    case ConsoleKey.Q:
                        Console.WriteLine("Exiting.");
                        _loop = false;
                        break;
                    default:
                        Console.WriteLine("Something went wrong. Please try again");
                        break;
                }
            }
            ;

        }

        private void ListAllGoals()
        {
            int _counter = 1;
            int _tPoints = 0;
            foreach (Goal gg in _eGoals)
            {

                Console.WriteLine($"\n----- Goal Entry {_counter++} --------------");
                Console.WriteLine($"Status: {gg.GetCheckbox()}  Name: {gg.GetName()}  Points: {gg.GetPoints()}");
                Console.WriteLine($"Description: {gg.GetDescription()}");
                // convert string to int
                if (gg.IsComplete())
                {

                    if (int.TryParse(gg.GetPoints(), out int _result))
                    {
                        _tPoints += _result;
                    }
                }

            }
            Console.WriteLine($">>> Points = {_tPoints}");
            _totalPoints = _tPoints;
        }

        public void DisplayPlayerfInfo()
        {
            Console.WriteLine($"Congratulations! You have {_totalPoints}");

        }
        public void ListGoalNames()
        {
            foreach (Goal a in _eGoals)
            {
                Console.WriteLine(a.GetName());
            }

        }
        public void ListGoalDetails()
        {
            foreach (Goal a in _eGoals)
            {
                Console.WriteLine($"Name: {a.GetName()}");
                Console.WriteLine($"Description: {a.GetDescription()}");
            }


        }
        public void CreateGoal()
        {
            int _inputCgTarget = 0;
            int _inputCgBonus = 0;
            // Get user choice from cl menu
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
                    _eGoals.Add(_sg);
                    // Console.WriteLine(_sg.GetDetailsString());
                    // Console.WriteLine(_sg.GetStringRepresentation());
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
                    _eGoals.Add(_eg);
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

                    Console.WriteLine($"Enter number of Target: ");
                    // string _inputCgTarget = Console.ReadLine();

                    // convert string to int
                    if (int.TryParse(Console.ReadLine(), out int _result))
                    {
                        _inputCgTarget = _result;
                    }

                    Console.WriteLine($"Enter number of Bonus: ");
                    // convert string to int
                    if (int.TryParse(Console.ReadLine(), out _result))
                    {
                        _inputCgBonus = _result;
                    }

                    ChecklistGoal _cg = new ChecklistGoal(_inputCgName, _inputCgDescription, _inputCgPoints, _inputCgTarget, _inputCgBonus);
                    _eGoals.Add(_cg);
                    Console.WriteLine(_cg.GetDetailsString());
                    Console.WriteLine(_cg.GetStringRepresentation());
                    break;

                default:
                    Console.WriteLine("Something went wrong. Please try again");
                    break;
            }
        }
        public void RecordEvent()
        {
            // Record event using the objects record event methods
            // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
            int _goalSelector = 1; // sequence to select a menu item
            // Present menu
            Console.WriteLine("\nWhich goal have you completed.");
            Console.WriteLine($"Please select from the following actions: ");
            // Build and present goal list with selector
            foreach (Goal g in _eGoals)
            {
                Console.WriteLine($"{_goalSelector++}: Goal: {g.GetName()}");
            }
            Console.Write("Enter a number: ");

            // Convert input to int
            if (int.TryParse(Console.ReadLine(), out int _result))
            {
                _goalSelector = _result - 1; // minus 1 for zero base indexing
            }
            // show details of selected goal
            Console.WriteLine($"Selected: '{_eGoals[_goalSelector].GetStringRepresentation()}'");

            // mark selected goal completed
            _eGoals[_goalSelector].RecordEvent();
            Console.WriteLine($"Completed: {_eGoals[_goalSelector].GetStringRepresentation()}");
            if (_eGoals[_goalSelector].IsComplete())
            {
                Console.WriteLine("This is done");
            }
            else
            {
                Console.WriteLine("Goal not completed");
            }

            foreach (Goal t in _eGoals)
            {
                // debug: Console.WriteLine($"{t.GetName()} = {t.GetPoints()} points.");

                // If the goal is completed, then add to points total
                if (t.IsComplete())
                {
                    _totalPoints += int.Parse(t.GetPoints());
                }
            }
            Console.WriteLine($">>> Points = {_totalPoints}");
        }
        public void SaveGoals(string file)
        {
            string _allGoals = "";
            foreach (Goal gString in _eGoals)
            {
                _allGoals += $"{gString.GetStringRepresentation()}\n";
            }
            File.WriteAllText(file, _allGoals);
            Console.WriteLine(_allGoals);
            Console.WriteLine("Saved to file: " + file);
        }


        public void LoadGoals(string file)
        {
            // Format of the goals files
            // Eternal Gaol format
            // EternalGoal:name,description,points
            // 
            // 
            // // 
            string[] lines = File.ReadAllLines(file);
            // List<string> _importGoals = new List<string>(
            // File.ReadAllLines(file)
            // );
            foreach (string line in lines)
            {
                // split off the type of goal
                string[] _goalString = line.Split(':');
                string _goalType = _goalString[0]; // This is the type of goal

                // split out the goal details and send to the constructor
                string[] parts = _goalString[1].Split(",");

                Console.WriteLine($"Goal type:{_goalType}");
                Console.WriteLine($"Goal details:{parts[0]}, {parts[1]}, {parts[2]}");
                if (_goalType == "EternalGoal")
                {
                    EternalGoal aeGoal = new EternalGoal(parts[0], parts[1], parts[2]);
                    _eGoals.Add(aeGoal);
                }
                else if (_goalType == "SimpleGoal")
                {
                    SimpleGoal sGoal = new SimpleGoal(parts[0], parts[1], parts[2]);
                    _eGoals.Add(sGoal);
                }
                else if (_goalType == "ChecklistGoal")
                {
                    int _aTarget = 0;
                    int _aBonus = 0;
                    int result;

                    // convert string to int
                    if (int.TryParse(parts[3], out result))
                    {
                        _aTarget = result;
                    }

                    // convert string to int
                    if (int.TryParse(parts[4], out result))
                    {
                        _aBonus = result;
                    }

                    ChecklistGoal cGoal = new ChecklistGoal(parts[0], parts[1], parts[2], _aTarget, _aBonus);
                    _eGoals.Add(cGoal);
                }
                else
                {
                    Console.WriteLine("Something went wrong importing line. Skipping.");
                }
            }
            Console.WriteLine($"{file} loaded.");
        }

    }
}