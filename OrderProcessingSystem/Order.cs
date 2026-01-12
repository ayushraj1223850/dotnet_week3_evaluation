using System.Collections.Generic;

/// <summary>
/// Represents an order placed by a customer.
/// </summary>
class Order
{
    public int OrderId { get; }
    public Customer Customer { get; }
    public List<OrderItem> Items { get; } = new List<OrderItem>();
    public OrderStatus CurrentStatus { get; private set; }
    public List<OrderStatusLog> StatusHistory { get; } = new List<OrderStatusLog>();

    public Order(int orderId, Customer customer)
    {
        OrderId = orderId;
        Customer = customer;
        CurrentStatus = OrderStatus.Created;
    }

    public void AddItem(OrderItem item)
    {
        Items.Add(item);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var item in Items)
        {
            total += item.GetItemTotal();
        }
        return total;
    }

    internal void UpdateStatus(OrderStatus newStatus)
    {
        StatusHistory.Add(new OrderStatusLog(CurrentStatus, newStatus));
        CurrentStatus = newStatus;
    }
}
