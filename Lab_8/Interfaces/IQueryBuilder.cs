namespace Lab_8.Interfaces
{
    public interface IQueryBuilder
    {
        IQueryBuilder Select(string tableName);
        IQueryBuilder Where(string condition);
        IQueryBuilder Limit(int limitCount);
        string GetSql();
    }
}
