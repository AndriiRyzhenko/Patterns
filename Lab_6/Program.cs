
using Lab_6;
using Lab_6.Entities;

class Program
{
    static void Main(string[] args)
    {
        var employee1 = new Employee { Name = "Tom", Salary = 1100 };
        var employee2 = new Employee { Name = "Jim", Salary = 2030 };
        var employee3 = new Employee { Name = "Nick", Salary = 3400 };

        var department1 = new Department { Name = "First Dep", Employees = new List<Employee> { employee1, employee2, employee3 } };

        var employee4 = new Employee { Name = "Mike", Salary = 1400 };
        var employee5 = new Employee { Name = "Jack", Salary = 2300 };

        var department2 = new Department { Name = "Second Dep", Employees = new List<Employee> { employee4, employee5 } };

        var company = new Company { Name = "CompanyName", Departments = new List<Department> { department1, department2 } };

        var visitor = new Visitor();

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Employee report:\n");
        GetReport(employee1, visitor);
        Console.WriteLine(new string('-', 30));

        Console.WriteLine("Department report:\n");
        GetReport(department1, visitor);
        Console.WriteLine(new string('-', 30));

        Console.WriteLine("Company report:\n");
        GetReport(company, visitor);
        Console.WriteLine(new string('-', 30));

        /*
        Console shows next:

        ------------------------------
        Employee report:

        Name: Tom, salary: 1100 UAH
        ------------------------------
        Department report:
        
        Department: First Dep
        Name: Tom, salary: 1100 UAH
        Name: Jim, salary: 2030 UAH
        Name: Nick, salary: 3400 UAH
        Total department salary: 6530 UAH
        ------------------------------
        Company report:
        
        Company: CompanyName
        Department: First Dep
        Name: Tom, salary: 1100 UAH
        Name: Jim, salary: 2030 UAH
        Name: Nick, salary: 3400 UAH
        Total department salary: 6530 UAH
        Department: Second Dep
        Name: Mike, salary: 1400 UAH
        Name: Jack, salary: 2300 UAH
        Total department salary: 3700 UAH
        Total company salary: 10230 UAH
        ------------------------------
        */
    }

    private static void GetReport(IEntity entity, IVisitor visitor)
    {
        entity.Accept(visitor);
    }
}
