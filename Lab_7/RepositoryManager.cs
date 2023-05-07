using Lab_7.Interfaces;
using Lab_7.Repositories;

namespace Lab_7
{
    public class RepositoryManager
    {
        public static IRepository GetRepository(string name)
        {
            switch (name)
            {
                case nameof(MongoDBRepository): return MongoDBRepository.GetInstance();
                case nameof(PostgreSQLRepository): return PostgreSQLRepository.GetInstance();
                default: throw new NotImplementedException();
            }
        }
    }
}
