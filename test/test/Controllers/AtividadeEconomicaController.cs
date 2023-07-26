using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class AtividadeEconomicaController : Controller
    {
        // GET: AtividadeEconomica
        public ActionResult Index()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<AtividadeEconomicaModel> list = new List<AtividadeEconomicaModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM AtividadeEconomica";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            AtividadeEconomicaModel ae = new AtividadeEconomicaModel();

                            ae.Codigo = int.Parse(reader["Codigo"].ToString());
                            ae.Nome = reader["Nome"].ToString();
                            ae.Ativa = Boolean.Parse(reader["Ativo"].ToString());

                            list.Add(ae);
                        }
                    }
                }
            }


            return View(list);
        }
        public ActionResult Criar()
        {
            AtividadeEconomicaModel ae = new AtividadeEconomicaModel();
            return View(ae);
        }

        [HttpPost]
        public ActionResult Salvar(AtividadeEconomicaModel ae)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO dbo.AtividadeEconomica(Codigo, Nome,Ativa) VALUES(@Codigo,@Nome,@Ativa)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Codigo", ae.Codigo);
                    command.Parameters.AddWithValue("@Nome", ae.Nome);
                    command.Parameters.AddWithValue("@Ativa", ae.Ativa);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return RedirectToAction("Criar");

        }
    }
}