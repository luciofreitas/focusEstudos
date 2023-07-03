using CadastroContatos2.Models;
using CadastroContatos2.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroContatos2.Controllers
{
    public class FormularioController : Controller
    {
        private readonly IContatoRepository _contatoRepository; // _ por ele ser privado
        public FormularioController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index","Contato");
                }
                return View(contato);
            }
            catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos criar seu contato, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
                throw;
            }
        }
    }
}
