using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Models;
using test.Services;

namespace test.Controllers
{
    public class SetorController : Controller
    {
        // GET: Setor
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Setores = SetorService.ObterSetores();
            return View();
        }
        public PartialViewResult Criar()
        {
            SetorModel setor = new SetorModel();
            return PartialView(setor);
        }
        [HttpPost]
        public ActionResult Salvar(SetorModel setor)
        {
            ViewBag.Setor = SetorService.InserirSetor(setor);
            return RedirectToAction("Index");
        }
    }
}
