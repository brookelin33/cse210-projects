public class Product
{
    public string Name { get; private set; }
    public string ProductID { get; private set; }
    public double ProductPrice { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, string productID, double productPrice, int quantity)
    {
        Name = name;
        ProductID = productID;
        ProductPrice = productPrice;
        Quantity = quantity;
    }

    public double GetTotalCostOfProduct()
    {
        return ProductPrice * Quantity;
    }
}