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

                string sql = "SELECT ID, Nome, Nome_Ingles, Ativa FROM Funcao";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FuncaoModel funcao = new FuncaoModel();

                            funcao.Id = int.Parse(reader["ID"].ToString());
                            funcao.Nome = reader["Nome"].ToString();
                            funcao.Nome_Ingles = reader["Nome_Ingles"].ToString();
                            funcao.Ativo = bool.Parse(reader["Ativa"].ToString());

                            list.Add(funcao);
                        }
                    }
                }
            }
            return list;
        }
        public static List<FuncaoModel> InserirFuncao(FuncaoModel funcao)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<FuncaoModel> list = new List<FuncaoModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO dbo.Funcao(Nome, Nome_Ingles,Ativa) VALUES(@Nome, @Nome_Ingles,@Ativa)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", funcao.Nome);
                    command.Parameters.AddWithValue("@Nome_Ingles", funcao.Nome_Ingles);
                    command.Parameters.AddWithValue("@Ativa", funcao.Ativo);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return list;
        }
    }

}