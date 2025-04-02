public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private double _shipping = 35.00;
    public Order(Customer c)
    {
        _customer = c;
        Product p1 = new Product("Bannana", 5234, 13.24,5);
        Product p2 = new Product("Zipper", 3338, 3.49,1);
        Product p3 = new Product("Clamp", 5853, 53.24,4);
        Product p4 = new Product("Newspaper", 1214, 2.00, 1);
        Product p5 = new Product("Vitamins", 8984, 36.19,2);
        _products.Add(p1);
        _products.Add(p2);
        _products.Add(p3);
        _products.Add(p4);
        _products.Add(p5);
    }
    public double TotalProductCost()
    {
    // total price = total cost + shipping
        foreach(Product p in _products)
        {
            
        }


        if(_customer.IsUSA())
        {
            _shipping = 5.00;
        }
        double _totalCost = _shipping;

        return _totalCost;
    }
    public void Display()
    {
        Console.WriteLine($"Order details:");
        foreach(Product p in _products)
        {
            p.Display();
        }
        
    }
    public void PackingLabel()
    {
        Console.WriteLine("this is packing");
    }

    public void ShippingLabel()
    {
        Console.WriteLine("this is Shipping");
    }


}