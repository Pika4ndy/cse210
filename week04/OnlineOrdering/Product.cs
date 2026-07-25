public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private int _quantity;

    public Product(string name, int ID, double price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    // Cost = price * quantity
    public double GetCost()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _productID;
    }
}