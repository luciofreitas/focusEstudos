using FocusHealthSolutionsTeste1.Data;
using FocusHealthSolutionsTeste1.Models;
using FocusHealthSolutionsTeste1.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusHealthSolutionsTeste1.Controllers
{
    public class PlanilhaController : Controller
    {
        private readonly IPlanilhaRepository _planilhaRepository;

        public PlanilhaController(IPlanilhaRepository planilhaRepository)
        {
            _planilhaRepository = planilhaRepository;
        }

        public IActionResult Index()
        {
            List<PlanilhaModel> planilha = _planilhaRepository.BuscarTodos();
            return View(planilha);
        } 
        public IActionResult Editar(string ficha)
        {
            PlanilhaModel dados = _planilhaRepository.BuscarPorFicha(ficha);
            return View(dados);
        }
        [HttpPost]
        public IActionResult Alterar(PlanilhaModel dados)
        {
            if (ModelState.IsValid)
            {
                _planilhaRepository.Atualizar(dados);
                return RedirectToAction("Index");
            }
            return View("Editar",dados);
        }
        public IActionResult Apagar()
        {
            return View();
        }

    }
}
