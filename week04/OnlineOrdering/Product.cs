
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
    public void Display(string options = "d")
    {
        if(options == "d")
        {
            Console.WriteLine("{0, -6}{1, -18}{2,10:C2}{3,-4}{4,5}{5,15:C2}", _productId, _name, _price, "", _quantity, _price * _quantity);
        }
        if(options == "p")
        {
            Console.WriteLine("{0, -6}{1, -18}{2,10}", _productId, _name, _quantity);
        }
    }
    public string GetProductPack()
    {
        return "\n" + _productId + "   " + _name + "   " + _quantity;
    }
    public double GetCost()
    {
        double _productCost = _price * _quantity;
        return (double) _productCost;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

}