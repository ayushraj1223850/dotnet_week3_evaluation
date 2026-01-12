using System;

class Program
{
    static void Main()
    {
        // Sample Products
        var p1 = new Product(1, "Laptop", 50000, "Electronics");
        var p2 = new Product(2, "Mouse", 500, "Electronics");

        // Sample Customers
        var c1 = new Customer(1, "Ayush", "ayush@mail.com");

        // Create Order
        var order = new Order(101, c1);
        order.AddItem(new OrderItem(p1, 1));
        order.AddItem(new OrderItem(p2, 2));

        // Order Service
        var service = new OrderService();

        // Subscribe notifications
        service.OrderStatusChanged += Notifications.CustomerNotification;
        service.OrderStatusChanged += Notifications.LogisticsNotification;

        service.CreateOrder(order);

        Console.WriteLine($"Order Total: {order.CalculateTotal()}");

        // Status flow
        service.ChangeOrderStatus(101, OrderStatus.Paid);
        service.ChangeOrderStatus(101, OrderStatus.Packed);
        service.ChangeOrderStatus(101, OrderStatus.Shipped);
        service.ChangeOrderStatus(101, OrderStatus.Delivered);

        // Print History
        Console.WriteLine("\nOrder Status History:");
        foreach (var log in order.StatusHistory)
        {
            Console.WriteLine($"{log.OldStatus} → {log.NewStatus} at {log.ChangedOn}");
        }
    }
}
