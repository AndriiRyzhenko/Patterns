namespace Lab_7.Interfaces;

public interface IRepository
{
    void Create(IEntity entity);
    IEntity Read(Guid id);
    void Update(IEntity entity);
    void Delete(Guid id);
}
