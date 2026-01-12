using System;

/// <summary>
/// Entry point of Payroll Application.
/// Demonstrates OOPS, Collections, and Delegates.
/// </summary>
class Program
{
    static void Main()
    {
        // Repository holds employee data
        EmployeeRepository repository = new EmployeeRepository();

        // Payroll processor uses repository
        PayrollProcessor payroll = new PayrollProcessor(repository);

        // Subscribe multiple methods to delegate (multicast delegate)
        payroll.SalaryProcessed += Notifications.HRNotification;
        payroll.SalaryProcessed += Notifications.FinanceNotification;

        Console.WriteLine("\n--- Payroll Processing Started ---\n");
        payroll.ProcessPayroll();

        Console.WriteLine("\n--- Payroll Summary ---\n");

        var paySlips = PayrollProcessor.GetPaySlips();
        double totalPayout = 0;

        foreach (var slip in paySlips)
        {
            totalPayout += slip.NetSalary;
        }

        Console.WriteLine($"Total Employees Processed: {paySlips.Count}");
        Console.WriteLine($"Total Salary Payout: {totalPayout}");
    }
}
