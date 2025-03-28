public class Order
{
    public List<Product> Products { get; private set; }

    public Customer Customer { get; private set; }

    public Order(Customer customer, List<Product> products)
    {
        Customer = customer;
        Products = products;
    }

    public double GetTotalCostOfOrder()
    {
        double totalCost = 0;
        foreach (Product product in Products)
        {
            totalCost += product.GetTotalCostOfProduct();
        }

        if (Customer.Address.IsUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address.ReturnAddress()}";
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in Products)
        {
            label += $"Name: {product.Name} -- Product ID:{product.ProductID}\n";
        }
        return label;
    }
}