using System.Web.Mvc;
using test.DTOs;
using test.Services;

namespace test.Controllers
{
    public class EmpregadosDTOController : Controller
    {
        public ActionResult EmpresaSelecaoEmpregado(int? empresaID)
        {
            ViewBag.ExibirEmpregados = EmpregadosService.ObterEmpregados(empresaID);        
            return View("Index");
        }
        public ActionResult Index()
        {
            ViewBag.EmpresaSelecaoEmpregado = EmpresaSelecaoEmpregadoService.ObterEmpresaSelecaoEmpregado();
            return View("EmpresaSelecaoEmpregado");
        }
        [HttpGet]
        public JsonResult ObterEmpregados(int empresaID)
        {
            var empregados = EmpregadosService.ObterEmpregados(empresaID);
            return Json(empregados, JsonRequestBehavior.AllowGet);
        }
        public PartialViewResult Criar()
        {
            ViewBag.Empresa = EmpresaService.ObterEmpresa();
            ViewBag.Funcao = FuncaoService.ObterFuncoes();
            ViewBag.Setor = SetorService.ObterSetores();
            EmpregadosDTO empregados = new EmpregadosDTO();
            return PartialView(empregados);
        }
        [HttpPost]
        public ActionResult Salvar(EmpregadosDTO empregados)
        {
            ViewBag.Empregado = EmpregadosService.InserirEmpregado(empregados);
            return RedirectToAction("Index", "EmpregadosDTO");
        }
        public PartialViewResult Editar(int id)
        {
            ViewBag.Empresa = EmpresaService.ObterEmpresa();
            ViewBag.Funcao = FuncaoService.ObterFuncoes();
            ViewBag.Setor = SetorService.ObterSetores();
            EmpregadosDTO empregado = EmpregadosService.ObterEmpregado(id);
            return PartialView(empregado);
        }
        [HttpPost]
        public string Alterar(EmpregadosDTO empregados)
        {
            EmpregadosService.EditarEmpregado(empregados);
            return "ok";
        }
        [HttpDelete]
        public string Apagar(int empregadoID)
        {
            EmpregadosService.DeletarEmpregado(empregadoID);
            return "ok";
        }
    }
}