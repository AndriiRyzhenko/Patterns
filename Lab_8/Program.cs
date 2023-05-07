using Lab_8.Builders;
using Lab_8.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        IQueryBuilder queryBuilder = new PostgreSqlQueryBuilder();
        string postgreSqlQuery = queryBuilder.Select("Products").Where("type = Phone").Limit(50).GetSql();
        Console.WriteLine(postgreSqlQuery);

        queryBuilder = new MySqlQueryBuilder();
        string mySqlQuery = queryBuilder.Select("Users").Where("age = 30").Limit(10).GetSql();
        Console.WriteLine(mySqlQuery);


        /*
        Console shows next:

        SELECT * FROM Products WHERE type = Phone LIMIT 50
        SELECT * FROM Users WHERE age = 30 LIMIT 10
        */
    }
}
