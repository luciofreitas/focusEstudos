using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FocusHealthSolutionsTeste2.Repository;
using FocusHealthSolutionsTeste2.Models;

namespace FocusHealthSolutionsTeste2.Controllers
{
    public class RegistroController : Controller
    {
        private readonly IRegistroRepository _registroRepository;

        public RegistroController(IRegistroRepository registroRepository)
        {
            _registroRepository = registroRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckBox(PlanilhaModel dado)
        {
            if (dado.Conf == checked(true))
            {
                _registroRepository.Adicionar(dado);
            }
            if (dado.Pres == checked(true))
            {
                _registroRepository.Adicionar(dado);
            }
            if (dado.ASO_Up == checked(true))
            {
                _registroRepository.Adicionar(dado);
            }
            if (dado.ASO_Prot == checked(true))
            {
                _registroRepository.Adicionar(dado);
            }
            if (dado.Pend == checked(true))
            {
                _registroRepository.Adicionar(dado);
            }
            if (dado.Tem_Av == checked(true))
            {
                _registroRepository.Adicionar(dado);
            }
            if (dado.Tem_Res == checked(true))
            {
                _registroRepository.Adicionar(dado);
            }
            return View(dado);
        }
        public IActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(PlanilhaModel dados)
        {
            if (ModelState.IsValid)
            {
                _registroRepository.Adicionar(dados);
                return RedirectToAction("Index","Planilha");
            }
            
            return View(dados);
        }
    }
}
