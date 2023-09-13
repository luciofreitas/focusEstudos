using System.Web.Mvc;
using test.DTOs;
using test.Services;

namespace test.Controllers
{
    public class MultiEmpresasController : Controller
    {

        public ActionResult MultiEmpresaSelecaoEmpregados(int[] empresaID)
        {
            var empregados = EmpregadosService.MultiEmpresaObterEmpregados(empresaID);
            return View("Index", empregados);
        }
        public ActionResult Index()
        {
            ViewBag.MultiEmpresaSelecaoEmpregado = EmpresaSelecaoEmpregadoService.ObterEmpresaSelecaoEmpregado();
            return View("MultiEmpresaSelecaoEmpregados");
        }
        [HttpGet]
        public JsonResult MultiEmpresaObterEmpregados(int[] empresaID)
        {
            var empregados = EmpregadosService.MultiEmpresaObterEmpregados(empresaID);
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

        public ActionResult Salvar(EmpregadosDTO empregados)
        {
            ViewBag.Empregado = EmpregadosService.InserirEmpregado(empregados);
            return RedirectToAction("Index");
        }
        public ActionResult Editar(int id)
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
            return "ok" ;
        }
        [HttpDelete]
        public string Apagar(int empregadoID)
        {
            EmpregadosService.DeletarEmpregado(empregadoID);
            return "ok";
        }
    }
}