using System.ComponentModel.DataAnnotations;

public class Address
{
    private string _street;
    private string _city;
    private string _state_province;
    private string _country;
    private bool _isUSA;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state_province = state;
        _country = country;
        if(_country.ToUpper() == "USA")
        {
            _isUSA = true;
        }

    }
    public void Display()
    {
        Console.WriteLine(_street);
        Console.WriteLine($"{_city}, {_state_province}");
    }
    public bool IsUSA()
    {
        if(_country == "USA")
        {
            _isUSA = true;
        }
        else
        {
            _isUSA = false;
        }
        return _isUSA;
    }

}