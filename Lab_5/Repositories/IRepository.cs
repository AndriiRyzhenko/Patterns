using Lab_5.Models;

namespace Lab_5.Repositories
{
    public interface IRepository
    {
        public Item Update(Item item);
        public Item Get(Guid id);
    }
}
