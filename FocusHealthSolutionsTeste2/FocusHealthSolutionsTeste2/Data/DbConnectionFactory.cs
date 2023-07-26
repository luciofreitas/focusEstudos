using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace FocusHealthSolutionsTeste2.Data
{
    public class DbConnectionFactory : IDisposable
    {
        private readonly SqlConnection connection;
        public void Dispose()
        {
            connection.Dispose();
            Dispose();
        }
    }
}
