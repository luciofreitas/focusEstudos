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
        public ActionResult EmpresaSelecaoEmpregado(int? empresaID)
        {
            var empregados = EmpregadosService.ObterEmpregados(empresaID);        
            return View("Index", empregados);
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