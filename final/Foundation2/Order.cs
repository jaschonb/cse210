public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    // Returns the total cost of a customer's order
    public double CalculateTotalCost()
    {
        double totalCost = 0;

        // Loops through each product and calls the
        // GetTotalPrice method to add on to the
        // total order cost.
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalPrice();
        }

        Console.WriteLine($"Total: ${Double.Round(totalCost, 2)}");

        // To calculate shipping, if the customer lives
        // in the USA, shipping is $5. Else, the shipping
        // is $35
        if (_customer.LivesInUSA())
        {
            Console.WriteLine("Shipping: $5");
            totalCost += 5;
        }
        else
        {
            Console.WriteLine("Shipping: $35");
            totalCost += 35;
        }

        return Double.Round(totalCost, 2);
    }

    // Returns a packaging label string
    public string getPackagingLabel()
    {
        // Creates an empty string to store the label
        string packagingLabel = "";

        // Loop through each product and add to the string a line
        // for each product
        foreach (Product product in _products)
        {
            packagingLabel += $"({product.GetQuantity()}) {product.GetName()} - {product.GetId()}\n";
        }

        return packagingLabel;
    }

    // Returns a shipping label string
    public string getShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }

    // Creates a product and adds it to the list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
}