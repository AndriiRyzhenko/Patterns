using Lab_5.Models;

namespace Lab_5.Repositories;

public class UserRepository : IRepository
{
    public Item Update(Item item)
    {
        // Update in DB and return new instance
        return item;
    }

    public Item Get(Guid id)
    {
        // return with a different email
        return new User { Email = "321@ukr.net" };
    }
}

