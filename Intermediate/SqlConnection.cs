using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    internal class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }             

        public override void OpeningConnection()
        {
            Console.WriteLine("Openning SqlConnection");
        }
        public override void ClosingConnection()
        {
            Console.WriteLine("Closing SqlConnection");
        }
    }
}
