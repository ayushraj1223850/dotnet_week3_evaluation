/// <summary>
/// Represents a product available for purchase.
/// </summary>
class Product
{
    public int ProductId { get; }
    public string Name { get; }
    public double Price { get; }
    public string Category { get; }

    public Product(int productId, string name, double price, string category)
    {
        ProductId = productId;
        Name = name;
        Price = price;
        Category = category;
    }
}
