using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.Services;
using test.DTOs;

namespace test.Controllers
{
    public class CidadeController : Controller
    {
        // GET: Cidade
        public ActionResult Index()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<CidadeEstadoDTO> list = new List<CidadeEstadoDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "sp_cidadesEstados";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CidadeEstadoDTO cidadeEstado = new CidadeEstadoDTO();

                            cidadeEstado.Nome = reader["Nome"].ToString();
                            cidadeEstado.NomeEstado = reader["NomeEstado"].ToString();
                            list.Add(cidadeEstado);
                        }
                    }
                }
            }
            return View(list);
        }

        public ActionResult Criar()
        {
            ViewBag.Estados = EstadoService.ObterEstados();
            CidadeModel cidade = new CidadeModel();
            return View(cidade);
        }

        [HttpPost]
        public ActionResult Salvar(CidadeModel cidade)
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO dbo.Cidade(Nome, Estado_ID) VALUES(@Nome, @Estado_ID)";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Nome", cidade.Nome);
                    command.Parameters.AddWithValue("@Estado_ID", cidade.Estado_ID);
     

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            return RedirectToAction("Index","Cidade");

        }
    }
}