using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using test.DTOs;
using test.Services;

namespace test.Controllers
{
    public class EmpregadosDTOController : Controller
    {
        // GET: Empregados
        public ActionResult Index()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";
            
            List<EmpregadosDTO> list = new List<EmpregadosDTO>();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "sp_empregados";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpregadosDTO procedure = new EmpregadosDTO();

                            procedure.Nome = reader["Nome"].ToString();
                            procedure.CPF = reader["CPF"].ToString();
                            procedure.RG_Passaport = reader["RGPassaporte"].ToString();
                            procedure.Data_Nascimento = DateTime.Parse(reader["DataNascimento"].ToString());
                            procedure.Ultimo_ASO = DateTime.Parse(reader["DataUltimaASO"].ToString());
                            procedure.Nome_Setor = reader["NomeSetor"].ToString();
                            procedure.Nome_Setor_Ingles = reader["NomeSetorIngles"].ToString();
                            procedure.Nome_Funcao = reader["NomeFunção"].ToString();
                            procedure.Nome_Funcao_Ingles = reader["NomeFunçãoIngles"].ToString();
                            procedure.Razao_Social = reader["Empresa"].ToString();
                            procedure.CNPJ = reader["CNPJ"].ToString();
                            procedure.Atividade_Economica = reader["AtividadeEconomica"].ToString();
                            procedure.Cidade = reader["Cidade"].ToString();
                            procedure.Estado = reader["Estado"].ToString();

                            list.Add(procedure);
                        }
                    }
                }
            }
                return View(list);
        }
        public ActionResult Criar()
        {

            return View();
        }
        public ActionResult Salvar()
        {

            return View();
        }
    }
}