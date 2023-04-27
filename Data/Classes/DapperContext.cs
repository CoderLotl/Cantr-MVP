using System.Data;
using System.Data.SQLite;

namespace Data
{
    public class DapperContext
    {
        private readonly string connectionString;

        public DapperContext(string connectionString)
        {
            this.connectionString = "Data Source = " + connectionString;
        }

        public string ConnectionString
        {
            get { return connectionString; }
        }

        public IDbConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
