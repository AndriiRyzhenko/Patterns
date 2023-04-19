namespace Lab_6.Entities;

public class Employee : IEntity
{
    public string Name { get; set; }
    public int Salary { get; set; }

    public int Accept(IVisitor visitor)
    {
        return visitor.VisitEmployee(this);
    }
}

