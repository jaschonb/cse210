public class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    // Returns the total price of the product
    public double GetTotalPrice()
    {
        return _price * _quantity;
    }

    // Returns the product name
    public string GetName()
    {
        return _name;
    }

    // Returns the product id
    public string GetId()
    {
        return _id;
    }

    // Returns the product quantity
    public int GetQuantity()
    {
        return _quantity;
    }
}