using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test.Services;
using test.DTOs;
using Newtonsoft.Json;

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
            EmpregadosFullDTO empregados = new EmpregadosFullDTO();
            return PartialView(empregados);
        }

        public ActionResult Salvar(EmpregadosFullDTO empregados)
        {
            ViewBag.Empregado = EmpregadosService.InserirEmpregado(empregados);
            return RedirectToAction("Index", "MultiEmpresas");
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