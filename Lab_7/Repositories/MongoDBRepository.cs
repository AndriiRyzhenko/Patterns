using Lab_7.Interfaces;

namespace Lab_7.Repositories;

public class MongoDBRepository : IRepository
{
    private static IRepository Instance;

    public static IRepository GetInstance()
    {
        if (Instance == null)
        {
            Instance = new MongoDBRepository();
        }
        return Instance;
    }

    public void Create(IEntity entity)
    {
        // Create entity in DB
        throw new NotImplementedException();
    }

    public void Delete(Guid id)
    {
        // Delete entity in DB
        throw new NotImplementedException();
    }

    public IEntity Read(Guid id)
    {
        // Read entity from DB and return
        throw new NotImplementedException();
    }

    public void Update(IEntity entity)
    {
        // Update entity in DB
        throw new NotImplementedException();
    }
}
