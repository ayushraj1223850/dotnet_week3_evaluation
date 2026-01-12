/// <summary>
/// Represents all possible states of an order.
/// Enum ensures only valid states are used.
/// </summary>
enum OrderStatus
{
    Created,
    Paid,
    Packed,
    Shipped,
    Delivered,
    Cancelled
}
