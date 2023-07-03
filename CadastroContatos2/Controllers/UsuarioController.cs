using CadastroContatos2.Models;
using CadastroContatos2.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroContatos2.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepository.BuscarTodos();
            return View(usuarios);
        }

        public IActionResult Editar(int id)//serve para fazer aparecer as informações nos inputs para serem alterados
        {
            var usuario = _usuarioRepository.ListarPorId(id);
            return View(usuario);
        }        

        [HttpPost]
        public IActionResult Alterar(EdicaoUsuarioModel edicaoUsuario)//serve para, de fato, alterar os campo.
        {
            try
            {
                UsuarioModel usuario = null;
                if (ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        Id = edicaoUsuario.Id,
                        Nome = edicaoUsuario.Nome,
                        Login = edicaoUsuario.Login,
                        Email = edicaoUsuario.Email,
                        Perfil = edicaoUsuario.Perfil
                    };
                    usuario = _usuarioRepository.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Usuario alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos alterar seu usuario, tente novemente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
                throw;
            }
        }
        public IActionResult Apagar(int id)
        {
            try
            {
                bool apagado = _usuarioRepository.Apagar(id);

                if (apagado)
                {
                    TempData["MensagemSucesso"] = "Usuario apagado com sucesso";
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, não conseguimos apagar seu usuario";
                }
                return RedirectToAction("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos apagar seu usuario, mais detalhes do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            UsuarioModel usuario = _usuarioRepository.ListarPorId(id);
            return View(usuario);
        }
    }
}
