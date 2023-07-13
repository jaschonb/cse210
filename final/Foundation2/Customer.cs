public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Returns true if the customer lives in the USA,
    // false if not
    public bool LivesInUSA()
    {
        return _address.LivesInUSA();
    }

    // Returns the customer's name
    public string GetName()
    {
        return _name;
    }

    // Returns the customer's address in string format
    public string GetAddress()
    {
        return _address.GetAddressString();
    }
}