using CadastroContatos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroContatos2.Repository
{
    public interface IUsuarioRepository
    {
        List<UsuarioModel> BuscarTodos();
        UsuarioModel ListarPorId(int id); 

        UsuarioModel Adicionar(UsuarioModel usuario);
        UsuarioModel Atualizar(UsuarioModel usuario);
        bool Apagar(int id);

    }
}
