using CadastroContatos2.Data;
using CadastroContatos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroContatos2.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public UsuarioModel ListarPorId(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }
        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            usuario.DataCadastro = DateTime.Now;
            //gravar no banco de dados
            _bancoContext.Usuarios.Add(usuario);
            //commitar no banco de dados
            _bancoContext.SaveChanges();
            return usuario;
        }
        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(usuario.Id);
            if (usuarioDB == null)
            {
                throw new System.Exception("Houve um erro na atualização do usuario");
            }
            else
            {
                usuarioDB.Nome = usuario.Nome;
                usuarioDB.Login = usuario.Login;
                usuarioDB.Email = usuario.Email;
                usuarioDB.Perfil = usuario.Perfil;
                usuarioDB.DataAtualizacao = DateTime.Now;


                _bancoContext.Usuarios.Update(usuarioDB);
                _bancoContext.SaveChanges();
                return usuarioDB;
            }
        }

        public bool Apagar(int id)
        {
            UsuarioModel usuarioDB = ListarPorId(id);
            if (usuarioDB == null)
            {
                throw new System.Exception("Houve um erro na deleção do usuario");
            }
            else
            {
                _bancoContext.Usuarios.Remove(usuarioDB);
                _bancoContext.SaveChanges();
                return true;
            }
        }
    }
}

