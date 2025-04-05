using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Markers", "1234", 10.99, 5);
        Product product2 = new Product("Laundry Detergent", "1243", 11.99, 2);
        List<Product> order1_products = new List<Product>();
        order1_products.Add(product1);
        order1_products.Add(product2);
        Address address1 = new Address("245 Main St", "Orem", "UT", "USA");
        Customer customer1 = new Customer("Cole", address1);
        Order order1 = new Order(customer1, order1_products);
        string packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();
        double totalCost1 = order1.GetTotalCostOfOrder();
        Console.WriteLine("Order Summary:");
        Console.WriteLine("--------");
        Console.WriteLine($"Packing Label:\n{packingLabel1}\nShipping Label:\n{shippingLabel1}\nTotal Cost: ${totalCost1:F2}");
        Console.WriteLine();

        Product product3 = new Product("Swimming Pool", "2345", 55.75, 1);
        Product product4 = new Product("Goggles", "3176", 15.60, 6);
        Product product5 = new Product("Sunscreen", "7306", 12.99, 2);
        List<Product> order2_products = new List<Product>();
        order2_products.Add(product3);
        order2_products.Add(product4);
        order2_products.Add(product5);
        Address address2 = new Address("64 Center St", "Calgary", "AB", "Canada");
        Customer customer2 = new Customer("Melanie", address2);
        Order order2 = new Order(customer2, order2_products);
        string packingLabel2 = order2.GetPackingLabel();
        string shippingLabel2 = order2.GetShippingLabel();
        double totalCost2 = order2.GetTotalCostOfOrder();
        Console.WriteLine("Order Summary:");
        Console.WriteLine("--------");
        Console.WriteLine($"Packing Label:\n{packingLabel2}\nShipping Label:\n{shippingLabel2}\nTotal Cost: ${totalCost2:F2}");
        Console.WriteLine();

    }
}