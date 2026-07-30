using System;

class Program
{
    static void Main(string[] args)
    {
        List<Customer> customersList = new List<Customer>();

        Customer yourself = new Customer("Myself Self", "12 row Street", "SomeCity", "Alabama", "USA");
        Customer joeDoe = new Customer("Joe Doe", "19 Street", "Hello", "Center", "New Zealand");
        Customer janeDoe = new Customer("Jane Doe", "1 Spoon Road", "New Delhi", "India");

        Address lastAddress = new Address("123 Forge Avenue", "Leisure", "Eldorado");
        Customer billJoe = new Customer("Bill Joe", lastAddress);


        Product iceScream = new Product("Ice Scream", 1001, 10.5, 4);
        Product chicken = new Product("Chicken Nuggets", 1020, 3.09, 10);
        Product chair = new Product("Wooden Chair", 2007, 49.99, 2);
        Product pencilSharpner = new Product("MetallicPencilSharpner", 3008, 5.01, 1);

        Order order1 = new Order(yourself);
        Order order2 = new Order(joeDoe);
        Order order3 = new Order(janeDoe);
        Order order4 = new Order(billJoe);

        order1.AddProduct(iceScream);
        order1.AddProduct(chicken);
        order1.AddProduct(chair);
        order1.AddProduct(pencilSharpner);

        order2.AddProduct(iceScream);
        order2.AddProduct(chicken);
        order2.AddProduct(chair);
        order2.AddProduct(pencilSharpner);

        order3.AddProduct(iceScream);
        order3.AddProduct(chair);

        order4.AddProduct(chicken);

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost()}");
        Console.WriteLine();

        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order4.GetTotalCost()}");
        Console.WriteLine();
    }
}