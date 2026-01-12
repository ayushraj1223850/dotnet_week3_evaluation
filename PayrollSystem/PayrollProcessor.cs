using System;
using System.Collections.Generic;

/// <summary>
/// Handles payroll processing logic.
/// Depends on EmployeeRepository for employee data.
/// </summary>
class PayrollProcessor
{
    private EmployeeRepository repository;

    // Static collection to store generated payslips
    private static List<PaySlip> paySlips = new List<PaySlip>();

    // Delegate for salary processed notification
    public Action<PaySlip>? SalaryProcessed;

    public PayrollProcessor(EmployeeRepository repository)
    {
        this.repository = repository;
    }

    // Processes payroll for all employees
    public void ProcessPayroll()
    {
        foreach (Employee emp in repository.GetAllEmployees())
        {
            PaySlip slip = emp.CalculateSalary();
            paySlips.Add(slip);

            // Notify subscribed handlers
            SalaryProcessed?.Invoke(slip);

            Console.WriteLine(
                $"Processed: {slip.Name} | {slip.EmployeeType} | Net: {slip.NetSalary}");
        }
    }

    // Returns all generated payslips
    public static List<PaySlip> GetPaySlips()
    {
        return paySlips;
    }
}
