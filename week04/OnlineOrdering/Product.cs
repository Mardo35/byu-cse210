public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int qty)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = qty;
    }

    public double CalculateTotalCost()
    {
        return _price * _quantity;
    }

    public string GetName() => _name;
    public string GetId() => _productId;
}