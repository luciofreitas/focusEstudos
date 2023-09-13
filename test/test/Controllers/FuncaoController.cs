using System.Web.Mvc;
using test.Models;
using test.Services;

namespace test.Controllers
{
    public class FuncaoController : Controller
    {
        // GET: Funcao
        public ActionResult Index()
        {
            ViewBag.Funcoes = FuncaoService.ObterFuncoes();
            return View();
        }
        public PartialViewResult Criar()
        {
            FuncaoModel funcao = new FuncaoModel();
            return PartialView(funcao);
        }

        [HttpPost]
        public ActionResult Salvar(FuncaoModel funcao)
        {
            ViewBag.Funcao = FuncaoService.InserirFuncao(funcao);
            return RedirectToAction("Index");

        }
    }
}