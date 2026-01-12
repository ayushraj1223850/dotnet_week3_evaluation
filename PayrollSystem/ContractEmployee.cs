/// <summary>
/// Represents a contract employee paid on daily basis.
/// </summary>
class ContractEmployee : Employee
{
    public ContractEmployee(int id, string name, double dailyRate, int daysWorked)
        : base(id, name, dailyRate, daysWorked)
    {
        EmployeeType = "Contract";
    }

    /// <summary>
    /// Calculates salary for contract employees.
    /// Applies service charge deduction.
    /// </summary>
    public override PaySlip CalculateSalary()
    {
        double grossSalary = basePay * workingDays;
        double serviceCharge = grossSalary * 0.02; // 2% service charge

        return new PaySlip
        {
            EmployeeId = EmployeeId,
            Name = Name,
            EmployeeType = EmployeeType,
            GrossSalary = grossSalary,
            Deductions = serviceCharge,
            NetSalary = grossSalary - serviceCharge
        };
    }
}
