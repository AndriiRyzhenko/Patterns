using Lab_5.Models;

namespace Lab_5.Repositories;

public class ProductRepository : IRepository
{
    public Item Update(Item item)
    {
        // Update in DB and return new instance
        return item;
    }

    public Item Get(Guid id)
    {
        return null;
    }
}

