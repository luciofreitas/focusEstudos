using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using test.Models;
namespace test.Services
{
    public class AtividadeEconomicaService
    {
        public static List<AtividadeEconomicaModel> ObterAtividadeEconomica()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<AtividadeEconomicaModel> list = new List<AtividadeEconomicaModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT ID, Nome FROM AtividadeEconomica";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AtividadeEconomicaModel ae = new AtividadeEconomicaModel();

                            ae.ID = int.Parse(reader["ID"].ToString());
                            ae.Nome = reader["Nome"].ToString();

                            list.Add(ae);
                        }
                    }
                }
            }
            return list;
        }
    }

}