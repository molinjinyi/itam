using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Itam.Core.Data
{
    public class MySqlDatabase : IDatabase
    {
        private static readonly string ConnectionString;
        static MySqlDatabase()
        {
            ConnectionString = "Server=168.168.1.106;Port=3306;Database=Itam;Uid=sa;Pwd=sa123456;";
        }

        public IDbConnection GetOpenConnection(bool mars = false)
        {
            var cs = ConnectionString;
            if (mars)
            {
                SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(cs) { MultipleActiveResultSets = true };
                cs = scsb.ConnectionString;
            }
            var connection = new MySqlConnection(cs);
            connection.Open();
            return connection;
        }

        public IDbConnection GetClosedConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
