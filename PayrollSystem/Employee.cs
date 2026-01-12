using System;

/// <summary>
/// Abstract base class representing a generic employee.
/// Enforces salary calculation using polymorphism.
/// </summary>
abstract class Employee
{
    public int EmployeeId { get; private set; }

    public string Name { get; private set; } = string.Empty;

    // Initialized to avoid nullable warning
    public string EmployeeType { get; protected set; } = string.Empty;

    protected double basePay;
    protected int workingDays;

    protected Employee(int id, string name, double basePay, int workingDays)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or empty.");

        if (basePay < 0)
            throw new ArgumentException("Base pay cannot be negative.");

        if (workingDays < 0 || workingDays > 31)
            throw new ArgumentException("Working days must be between 0 and 31.");

        EmployeeId = id;
        Name = name;
        this.basePay = basePay;
        this.workingDays = workingDays;
    }

    /// <summary>
    /// Calculates salary and returns PaySlip.
    /// Implemented by derived classes.
    /// </summary>
    public abstract PaySlip CalculateSalary();
}
