using System.Data.SqlClient;
using System.Web.Mvc;
using test.DTOs;
using test.Models;
using test.Services;

namespace test.Controllers
{
    public class EmpregadosFullDTOController : Controller
    {
       
        public ActionResult Criar()
        {
            ViewBag.Empresa = EmpresaService.ObterEmpresa();
            ViewBag.Funcao = FuncaoService.ObterFuncoes();
            ViewBag.Setor = SetorService.ObterSetores();
            EmpregadosFullDTO empregados = new EmpregadosFullDTO();
            return View(empregados);
        }
        [HttpPost]
        public ActionResult Salvar(EmpregadosFullDTO empregados)
        {
            ViewBag.Empregado = EmpregadosService.InserirEmpregado(empregados);
            return RedirectToAction("Criar","EmpregadosFullDTO");

        }
    }
}