/// <summary>
/// Represents payroll result for an employee.
/// </summary>
class PaySlip
{
    public int EmployeeId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string EmployeeType { get; set; } = string.Empty;

    public double GrossSalary { get; set; }
    public double Deductions { get; set; }
    public double NetSalary { get; set; }
}
