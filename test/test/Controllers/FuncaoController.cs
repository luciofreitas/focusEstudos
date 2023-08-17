using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class FuncaoController : Controller
    {
        // GET: Funcao
        public ActionResult Index()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<FuncaoModel> list = new List<FuncaoModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Funcao";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FuncaoModel funcao = new FuncaoModel();

                            funcao.Nome = reader["Nome"].ToString();
                            funcao.Nome_Ingles = reader["Nome_Ingles"].ToString();
                            funcao.Ativa = Boolean.Parse(reader["Ativa"].ToString());

                            list.Add(funcao);
                        }
                    }
                }
            }


            return View(list);
        }
        public PartialViewResult Criar()
        {
            FuncaoModel funcao = new FuncaoModel();
            return PartialView(funcao);
        }

        [HttpPost]
        public ActionResult Salvar(FuncaoModel funcao)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO dbo.Funcao(Nome, Nome_Ingles,Ativa) VALUES(@Nome, @Nome_Ingles,@Ativa)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", funcao.Nome);
                    command.Parameters.AddWithValue("@Nome_Ingles", funcao.Nome_Ingles);
                    command.Parameters.AddWithValue("@Ativa", funcao.Ativa);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return RedirectToAction("Index");

        }
    }
}