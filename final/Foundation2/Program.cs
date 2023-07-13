using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new address, customer, and order
        Address address1 = new Address("1234 Penelope Ave", "Sequim", "Washington", "USA");
        Customer customer1 = new Customer("Samuel", address1);
        Order order1 = new Order(customer1);

        // Add products to the order
        order1.AddProduct(new Product("Watermelon", "5W6M7O", 2.53, 3));
        order1.AddProduct(new Product("Infinite Ladder", "Q65C7T", 99.99, 1));
        order1.AddProduct(new Product("Endless Water Bucket", "E7W1B9", 53.47, 3));

        // Create a new address, customer, and order
        Address address2 = new Address("4321 Hanway Rd", "Villa Altagracia", "Los Alcarrizos", "Dominican Republic");
        Customer customer2 = new Customer("Tim", address2);
        Order order2 = new Order(customer2);

        // Add products to the order
        order2.AddProduct(new Product("Strawberries", "S6B4Y8", 2.79, 5));
        order2.AddProduct(new Product("Coolest Shirt Ever", "C5S4E8", 38.42, 1));
        order2.AddProduct(new Product("Junior Mints", "J7H9M6", 3.41, 2));

        // Write the order to the console along with its shipping label and total cost
        Console.WriteLine("Order 1:\n");
        Console.WriteLine($"Packing Label:\n{order1.getPackagingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.getShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine();

        // Write the order to the console along with its shipping label and total cost
        Console.WriteLine("Order 2:\n");
        Console.WriteLine($"Packing Label:\n{order2.getPackagingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.getShippingLabel()}\n");
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}\n");
    }
}