using ControleDeContatos.Models;
using ControleDeContatos.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly InterfaceContatoRepository _contaRepository;
        public ContatoController(InterfaceContatoRepository contatoRepository)
        {
            this._contaRepository = contatoRepository;
        }
        public IActionResult Index()
        {
            List <ContatoModel> contatos = _contaRepository.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
           ContatoModel contato =  _contaRepository.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contaRepository.ListarPorId(id);
            return View(contato);
        }
        public IActionResult Apagar(int id)
        {
            _contaRepository.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contaRepository.Adicionar(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(ContatoModel contato)
        {
            _contaRepository.Atualizar(contato);
            return RedirectToAction("Index");
        }
    }
}
