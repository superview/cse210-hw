public class Person
{
    // Declare private variable with no initial value
    private string _title;
    // You can set default or initial values at declaration
    private string _firstName = "Rick";
    private string _lastName = "Paul";
    public Person()
    {
        // Constructor with no parameters
        Console.WriteLine("Enter a name");
        _firstName = "Anonymous";
        _firstName = Console.ReadLine();
        _title = "";
        _lastName = "Nottingham";
    }
    public Person(string fname)
    {
        // Constuctor with one parameter
        _firstName = fname;
        _lastName = "Unknown";
    }

    public Person(string fname, string lname)
    {
        // Constructor with two parameters
        // The constructor selected 
        _firstName = fname;
        _lastName = lname;
    }

    public string GetInformalSignature()
    {
        return "Thanks, " + _firstName;

    }
     public string GetFormalSignature()
    {
        return "Sincerely, " + GetFullName();
    }

    private string GetFullName()
    {
        return _title + " " + _firstName + " " + _lastName;
    }
}