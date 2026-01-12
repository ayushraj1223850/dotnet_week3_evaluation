/// <summary>
/// Contains notification handlers for order status updates.
/// </summary>
class Notifications
{
    public static void CustomerNotification(Order order, OrderStatus oldStatus, OrderStatus newStatus)
    {
        Console.WriteLine($"[Customer] Order {order.OrderId} status changed from {oldStatus} to {newStatus}");
    }

    public static void LogisticsNotification(Order order, OrderStatus oldStatus, OrderStatus newStatus)
    {
        if (newStatus == OrderStatus.Shipped)
        {
            Console.WriteLine($"[Logistics] Order {order.OrderId} ready for delivery.");
        }
    }
}
