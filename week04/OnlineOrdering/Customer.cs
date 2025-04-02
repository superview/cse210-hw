public class Customer
{
    private string _name;
    private Address _Address;
    public Customer(string name, Address a)
    {
        _name = name;
        _Address = a;

    }
    public bool IsUSA()
    {
        return true;

    }
    public void Display()
    {
        Console.WriteLine(_name);
        // _Address.Display();
    }
}