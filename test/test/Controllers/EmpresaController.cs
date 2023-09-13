using System.Web.Mvc;
using test.DTOs;
using test.Models;
using test.PastObj;
using test.Services;


namespace test.Controllers
{
    public class EmpresaController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Empresas = EmpresaService.ObterEmpresas();
            return View();
        }

        public PartialViewResult Criar()
        {
            EmpresaDTO empresa = new EmpresaDTO();
            return PartialView(empresa);
        }
        [HttpPost]
        public ActionResult AtividadesEconomicas()
        {
            var json = WebContext.GET($"https://servicodados.ibge.gov.br/api/v2/cnae/classes");
            return Content(json);
        }
        [HttpPost]
        public ActionResult Cidades()
        {
            var json = WebContext.GET($"https://servicodados.ibge.gov.br/api/v1/localidades/distritos?orderBy=nome");
            return Content(json);
        }

        [HttpPost]
        public ActionResult Salvar(EmpresaDTO empresa)
        {
            ViewBag.Empresa = EmpresaService.InserirEmpresa(empresa);
            return RedirectToAction("Index");

        }
    }
}