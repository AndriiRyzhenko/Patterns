using Lab_7;
using Lab_7.Interfaces;
using Lab_7.Repositories;

class Program
{
    static void Main(string[] args)
    {
        IRepository mongoDBRepository = RepositoryManager.GetRepository(nameof(MongoDBRepository));
        IRepository postgreSQLRepository = RepositoryManager.GetRepository(nameof(PostgreSQLRepository));

        // Checking the correctness of the generated types
        if (mongoDBRepository is MongoDBRepository)
        {
            Console.WriteLine("mongoDBRepository is MongoDBRepository type");
        }

        if (postgreSQLRepository is PostgreSQLRepository)
        {
            Console.WriteLine("postgreSQLRepository is PostgreSQLRepository type");
        }

        /*
        Console shows next:

        mongoDBRepository is MongoDBRepository type
        postgreSQLRepository is PostgreSQLRepository type
        */
    }
}
