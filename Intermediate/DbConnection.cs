using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    internal abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection string should not be empty"); 
            
            ConnectionString = connectionString;
            Timeout = TimeSpan.FromSeconds(30);
        }
        public abstract void OpeningConnection();
        public abstract void ClosingConnection();
    }
}
