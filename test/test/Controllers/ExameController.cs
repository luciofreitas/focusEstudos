using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Services;
using test.DTOs;
namespace test.Controllers
{
    public class ExameController : Controller
    {
        // GET: Exame
        public ActionResult Index()
        {
            var exames = ExameService.ObterExames();
            return View(exames);
        }
        public PartialViewResult Criar()
        {
            ViewBag.NomeExame = ExameService.ObterNomeExames();
            ViewBag.Empresa = EmpresaService.ObterEmpresa();
            return PartialView();
        }
        [HttpPost]
        public ActionResult Salvar(ExameDTO exame)
        {
 
            ViewBag.Exame = ExameService.InserirExame(exame);
            return RedirectToAction("Index");
        }

        public PartialViewResult Editar(int id)
        {
            ViewBag.Empresa = EmpresaService.ObterEmpresa();
            ExameDTO exame = ExameService.ObterExame(id);
            return PartialView(exame);
        }
        [HttpPost]
        public string Alterar(ExameDTO exame)
        {
            ExameService.EditarExame(exame);
            return "ok";
        }
        [HttpDelete]
        public string Apagar(int exameID)
        {
            ExameService.DeletarExame(exameID);
            return "ok";
        }

    }
}