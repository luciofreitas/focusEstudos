using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using test.DTOs;
using test.Services;

namespace test.Controllers
{
    public class EmpresaController : Controller
    {
        // GET: Empresa
        public ActionResult Index()
        {
            string connectionString = "Server=./;Database=FocusEmpregadosEmpresa;User Id=sa; Password=Lf261192@;Encrypt=True;TrustServerCertificate=True";

            List<EmpresaDTO> list = new List<EmpresaDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "sp_empresa";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EmpresaDTO empresa = new EmpresaDTO();

                            empresa.RazaoSocial = reader["RazaoSocial"].ToString();
                            empresa.NumeroEmpregados = int.Parse(reader["NumeroEmpregados"].ToString());
                            empresa.CNAE = reader["CNAE"].ToString();
                            empresa.Data_Cadastro = DateTime.Parse(reader["Data_Cadastro"].ToString());
                            empresa.Observacao = reader["Observacao"].ToString();
                            empresa.CNPJ = reader["CNPJ"].ToString();
                            empresa.Endereco = reader["Endereco"].ToString();
                            empresa.Complemento = reader["Complemento"].ToString();
                            empresa.Bairro = reader["Bairro"].ToString();
                            empresa.CEP = reader["CEP"].ToString();
                            empresa.Atividade_Economica = reader["AtividadeEconomica"].ToString();
                            empresa.Cidade = reader["Cidade"].ToString();
                            list.Add(empresa);
                        }
                    }
                }
            }
            return View(list);
        }
        public ActionResult Criar()
        {
            ViewBag.AtividadeEconomica = AtividadeEconomicaService.ObterAtividadeEconomica();
            ViewBag.Cidade = CidadeService.ObterCidade();
            EmpresaDTO empresa = new EmpresaDTO();
            return View(empresa);
        }

        [HttpPost]
        public ActionResult Salvar(EmpresaDTO empresa)
        {
            ViewBag.Empresa = EmpresaService.InserirEmpresa(empresa);
            return RedirectToAction("Index");

        }
    }
}