using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    internal class DbCommand
    {
        private readonly DbConnection _connection;
        private readonly string _instruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new ArgumentNullException("Connection cannot be null");
            _connection = connection;
            if (string.IsNullOrWhiteSpace(instruction))
                throw new ArgumentNullException("Instruction cannot be null");
            _instruction = instruction;
        }
        public void Execute()
        {
            _connection.OpeningConnection();
            Console.WriteLine($"Executing instruction: {_instruction}");
            _connection.ClosingConnection();
        }
    }
}
