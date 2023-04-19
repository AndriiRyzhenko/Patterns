namespace Lab_6.Entities;

public interface IEntity
{
    int Accept(IVisitor visitor);
}

