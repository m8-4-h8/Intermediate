using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    internal class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpeningConnection()
        {
            Console.WriteLine("Openning OracleConnection");
        }
        public override void ClosingConnection()
        {
            Console.WriteLine("Closing OracleConnection");
        }
    }
}
