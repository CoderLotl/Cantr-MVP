using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        	get { return connectionString;}
        }

        public IDbConnection GetConnection()
        {            
            return new SQLiteConnection( connectionString );
        }
    }
}
