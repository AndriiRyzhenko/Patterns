namespace Lab_6.Entities;

public class Department : IEntity
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }
    public int Accept(IVisitor visitor)
    {
        return visitor.VisitDepartment(this);
    }
}

