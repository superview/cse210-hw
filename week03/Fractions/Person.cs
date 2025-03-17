public class Person
{
    private string _title;
    private string _firstName;
    private string _lastName;
    public Person()
    {
        _firstName = "John";
        _lastName = "Doe";
        _title = "Mr.";
    }
    public Person(string first, string last)
    {
        _firstName = first;
        _lastName = last; 
        _title = "";
    }
    public Person(string first, string last, string title)
    {
        _firstName = first;
        _lastName = last; 
        _title = title;
    }
    public string GetInformationalSignature()
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
    public void SetFirstName(string firstName)
    {

        _firstName = firstName;
    }
}
