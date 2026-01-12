/// <summary>
/// Represents a full-time employee with monthly salary.
/// </summary>
class FullTimeEmployee : Employee
{
    public FullTimeEmployee(int id, string name, double monthlySalary)
        : base(id, name, monthlySalary, 30)
    {
        EmployeeType = "Full-Time";
    }

    public override PaySlip CalculateSalary()
    {
        double tax = basePay * 0.10;
        double insurance = 2000;
        double deductions = tax + insurance;

        return new PaySlip
        {
            EmployeeId = EmployeeId,
            Name = Name,
            EmployeeType = EmployeeType,
            GrossSalary = basePay,
            Deductions = deductions,
            NetSalary = basePay - deductions
        };
    }
}
