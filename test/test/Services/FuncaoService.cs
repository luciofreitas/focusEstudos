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
    public class FuncaoService
    {
        public static List<FuncaoModel> ObterFuncoes()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<FuncaoModel> list = new List<FuncaoModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ID, Nome FROM Funcao";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FuncaoModel funcao = new FuncaoModel();

                            funcao.Id = int.Parse(reader["ID"].ToString());
                            funcao.Nome = reader["Nome"].ToString();

                            list.Add(funcao);
                        }
                    }
                }
            }
            return list;
        }
    }

}