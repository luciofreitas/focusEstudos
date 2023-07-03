using CadastroContatos2.Models;
using CadastroContatos2.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroContatos2.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        public ContatoController(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepository.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Editar(int id)//serve para fazer aparecer os campos nos inputs para serem alterados
        {
            ContatoModel contato = _contatoRepository.ListarPorId(id);
            return View(contato);
        }
        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)//serve para, de fato, alterar os campo.
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepository.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View("Editar", contato);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar seu contato, tente novemente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
                throw;
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _contatoRepository.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Contato apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, não conseguimos apagar seu contato";
                }
                return RedirectToAction("Index");
            }
            catch(Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu contato, mais detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepository.ListarPorId(id);
            return View(contato);
        }
    }
}
