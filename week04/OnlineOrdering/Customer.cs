public class Customer
{
    private string _name;
    private Address _Address;
    public Customer(string name, Address a)
    {
        _name = name;
        _Address = a;

    }
    public string GetCustomer()
    {
        return _name + '\n' + _Address.GetAddress();
    }
    public bool IsUSA()
    {
        return _Address.IsUSA();

    }
    public void Display()
    {
        Console.WriteLine(_name);
        _Address.Display();
    }
}