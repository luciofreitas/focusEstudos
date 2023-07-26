using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.Controllers;
namespace test.Services
{
    public class CidadeService
    {
        public static List<CidadeModel> ObterCidade()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<CidadeModel> list = new List<CidadeModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ID, Nome FROM Cidade";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CidadeModel cidade = new CidadeModel();

                            cidade.ID = int.Parse(reader["ID"].ToString());
                            cidade.Nome = reader["Nome"].ToString();

                            list.Add(cidade);
                        }
                    }
                }
            }
            return list;
        }
    }

}