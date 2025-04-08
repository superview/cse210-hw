// a regular class called Person1
public class Person1
{
    // parent class aka: base or super
    private string _name;
    public Person1(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
}

public class Student1 : Person1
{
    // child class aka: derrived or sub
    // derived from Person1
    private string _number;
    public Student1(string name, string number) : base(name)
    {
        _number = number;
    }
    public string GetNumber()
    {
        return _number;
    }
    public string GetAName()
    {
        return "doh!";
    }
}
//
