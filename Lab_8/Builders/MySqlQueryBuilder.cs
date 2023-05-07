using Lab_8.Interfaces;

namespace Lab_8.Builders
{
    public class MySqlQueryBuilder : IQueryBuilder
    {
        private string _select;
        private string _where;
        private int _limit;

        public IQueryBuilder Select(string tableName)
        {
            _select = $"SELECT * FROM {tableName}";
            return this;
        }

        public IQueryBuilder Where(string condition)
        {
            if (!string.IsNullOrEmpty(condition))
            {
                _where = $"WHERE {condition}";
            }
            return this;
        }

        public IQueryBuilder Limit(int limit)
        {
            _limit = limit;
            return this;
        }

        public string GetSql()
        {
            if (string.IsNullOrEmpty(_select))
            {
                throw new Exception("The 'SELECT' statement is missing");
            }

            string sql = _select;
            if (!string.IsNullOrEmpty(_where))
            {
                sql += $" {_where}";
            }

            if (_limit > 0)
            {
                sql += $" LIMIT {_limit}";
            }

            return sql;
        }
    }
}
