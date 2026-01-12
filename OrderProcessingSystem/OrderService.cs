using System;
using System.Collections.Generic;

class OrderService
{
    private static Dictionary<int, Order> orders = new Dictionary<int, Order>();

    public Action<Order, OrderStatus, OrderStatus>? OrderStatusChanged;

    public void CreateOrder(Order order)
    {
        orders.Add(order.OrderId, order);
        Console.WriteLine($"Order {order.OrderId} created successfully.");
    }

    public void ChangeOrderStatus(int orderId, OrderStatus newStatus)
    {
        if (!orders.ContainsKey(orderId))
        {
            Console.WriteLine("Order not found.");
            return;
        }

        Order order = orders[orderId];
        OrderStatus oldStatus = order.CurrentStatus;

        if (!IsValidTransition(oldStatus, newStatus))
        {
            Console.WriteLine($"Invalid transition: {oldStatus} → {newStatus}");
            return;
        }

        order.UpdateStatus(newStatus);
        OrderStatusChanged?.Invoke(order, oldStatus, newStatus);
    }

    /// <summary>
    /// Validates allowed order status transitions.
    /// </summary>
    private bool IsValidTransition(OrderStatus current, OrderStatus next)
    {
        if (current == OrderStatus.Cancelled || current == OrderStatus.Delivered)
            return false;

        return (current, next) switch
        {
            (OrderStatus.Created, OrderStatus.Paid) => true,
            (OrderStatus.Paid, OrderStatus.Packed) => true,
            (OrderStatus.Packed, OrderStatus.Shipped) => true,
            (OrderStatus.Shipped, OrderStatus.Delivered) => true,
            (_, OrderStatus.Cancelled) => true,
            _ => false
        };
    }
}
