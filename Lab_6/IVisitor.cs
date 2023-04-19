using Lab_6.Entities;

namespace Lab_6;

public interface IVisitor
{
    int VisitCompany(Company company);
    int VisitDepartment(Department department);
    int VisitEmployee(Employee employee);
}
