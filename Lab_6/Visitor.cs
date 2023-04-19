using Lab_6.Entities;

namespace Lab_6;

public class Visitor : IVisitor
{
    public int VisitCompany(Company company)
    {
        int totalCompanySalary = 0;
        Console.WriteLine($"Company: {company.Name}");
        foreach (var employee in company.Departments)
        {
            totalCompanySalary += VisitDepartment(employee);
        }

        Console.WriteLine($"Total company salary: {totalCompanySalary} UAH");
        return totalCompanySalary;
    }

    public int VisitDepartment(Department department)
    {
        int totalDepartmentSalary = 0;
        Console.WriteLine($"Department: {department.Name}");
        foreach (var employee in department.Employees)
        {
            totalDepartmentSalary += VisitEmployee(employee);
        }

        Console.WriteLine($"Total department salary: {totalDepartmentSalary} UAH");
        return totalDepartmentSalary;
    }

    public int VisitEmployee(Employee employee)
    {
        Console.WriteLine($"Name: {employee.Name}, salary: {employee.Salary} UAH");
        return employee.Salary;
    }
}

