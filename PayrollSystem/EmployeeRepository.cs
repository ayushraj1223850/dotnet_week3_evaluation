using System.Collections.Generic;

class EmployeeRepository
{
    // Static in-memory store (acts like database)
    private static List<Employee> employees = new List<Employee>();

    // Static constructor loads sample data once
    static EmployeeRepository()
    {
        employees.Add(new FullTimeEmployee(1, "Amit", 50000));
        employees.Add(new FullTimeEmployee(2, "Neha", 60000));
        employees.Add(new ContractEmployee(3, "Rahul", 1200, 25));
        employees.Add(new ContractEmployee(4, "Priya", 1000, 28));
    }

    // Returns all employees to service layer
    public List<Employee> GetAllEmployees()
    {
        return employees;
    }
}
