using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class SetorController : Controller
    {
        // GET: Setor
        [HttpGet]
        public ActionResult Index()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<SetorModel> list = new List<SetorModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Setor";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            SetorModel setor = new SetorModel();

                            setor.Nome = reader["Nome"].ToString();
                            setor.Nome_Ingles = reader["Nome_Ingles"].ToString();
                            setor.Ativa = Boolean.Parse(reader["Ativa"].ToString());

                            list.Add(setor);
                        }
                    }
                }
            }
            return View(list);
        }
        public ActionResult Criar()
        {
            SetorModel setor = new SetorModel();
            return View(setor);
        }

        [HttpPost]
        public ActionResult Salvar(SetorModel setor)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO dbo.Setor(Nome, Nome_Ingles,Ativa) VALUES(@Nome, @Nome_Ingles,@Ativa)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", setor.Nome);
                    command.Parameters.AddWithValue("@Nome_Ingles", setor.Nome_Ingles);
                    command.Parameters.AddWithValue("@Ativa", setor.Ativa);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return RedirectToAction("Index");

        }
    }
}