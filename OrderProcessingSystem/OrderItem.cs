/// <summary>
/// Represents a single item inside an order.
/// </summary>
class OrderItem
{
    public Product Product { get; }
    public int Quantity { get; }

    public OrderItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public double GetItemTotal()
    {
        return Product.Price * Quantity;
    }
}
