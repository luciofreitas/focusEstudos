using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;

namespace test.Controllers
{
    public class EstadoController : Controller
    {
        // GET: Estado
        public ActionResult Index()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<EstadoModel> list = new List<EstadoModel>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM Estado";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EstadoModel estado = new EstadoModel();

                            estado.Nome = reader["Nome"].ToString();
                            estado.Siglas = reader["Siglas"].ToString();

                            list.Add(estado);
                        }
                    }
                }
            }
            return View(list);
        }
        public ActionResult Criar()
        {
            EstadoModel estado = new EstadoModel();
            return View(estado);
        }

        [HttpPost]
        public ActionResult Salvar(EstadoModel estado)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO dbo.Estado(Nome, Siglas) VALUES(@Nome, @Siglas)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", estado.Nome);
                    command.Parameters.AddWithValue("@Siglas", estado.Siglas);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return RedirectToAction("Index");

        }
    }
}