namespace Lab_6.Entities;

public class Company : IEntity
{
    public string Name { get; set; }
    public List<Department> Departments { get; set; }
    public int Accept(IVisitor visitor)
    {
        return visitor.VisitCompany(this);
    }
}

