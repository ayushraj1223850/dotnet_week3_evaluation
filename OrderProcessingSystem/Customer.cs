/// <summary>
/// Represents a customer placing orders.
/// </summary>
class Customer
{
    public int CustomerId { get; }
    public string Name { get; }
    public string Email { get; }

    public Customer(int customerId, string name, string email)
    {
        CustomerId = customerId;
        Name = name;
        Email = email;
    }
}
