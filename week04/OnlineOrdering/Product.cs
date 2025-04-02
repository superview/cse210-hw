
public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;
    private float CalculateCost()
    {
        return (float) 1.11;
    }
    public Product(string name, int pid, double price, int quantity)
    {
        _name = name;
        _productId = pid;
        _price = price;
        _quantity = quantity;
    }
    public void Display()
    {
        Console.WriteLine($"{_name} {_price:F2} {_quantity}");
    }
    public float GetCost()
    {
        return (float) 2.22;
    }

}