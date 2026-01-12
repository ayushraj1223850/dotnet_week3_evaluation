/// <summary>
/// Notification handlers subscribed to payroll delegate.
/// </summary>
class Notifications
{
    public static void HRNotification(PaySlip slip)
    {
        Console.WriteLine($"[HR] Salary processed for {slip.Name}");
    }

    public static void FinanceNotification(PaySlip slip)
    {
        Console.WriteLine($"[Finance] Amount {slip.NetSalary} credited");
    }
}
