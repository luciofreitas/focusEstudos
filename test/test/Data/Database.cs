using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using test.Models;

namespace test.Data
{
    public class Database
    {
        public string sqlConn()
        {
            return ConfigurationManager.AppSettings["SqlConnection"];
        }
        public DataTable List()
        {
            using (SqlConnection con = new SqlConnection(sqlConn()))
            {
                string spString = "";
                SqlCommand command = new SqlCommand(spString, con);

                command.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}