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
    public class EstadoService
    {
        public static List<EstadoModel> ObterEstados()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<EstadoModel> list = new List<EstadoModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ID, Nome FROM Estado";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EstadoModel estado = new EstadoModel();

                            estado.ID = int.Parse(reader["ID"].ToString());
                            estado.Nome = reader["Nome"].ToString();

                            list.Add(estado);
                        }
                    }
                }
            }
            return list;
        }
    }
      
}