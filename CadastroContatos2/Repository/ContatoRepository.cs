﻿using CadastroContatos2.Data;
using CadastroContatos2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroContatos2.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            //gravar no banco de dados
            _bancoContext.Contatos.Add(contato);
            //commitar no banco de dados
            _bancoContext.SaveChanges();
            return contato;
        }
        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);
            if (contatoDB == null)
            {
                throw new System.Exception("Houve um erro na atualização do contato");
            }
            else
            {
                contatoDB.Nome = contato.Nome;
                contatoDB.Email = contato.Email;
                contatoDB.Celular = contato.Celular;

                _bancoContext.Contatos.Update(contatoDB);
                _bancoContext.SaveChanges();
                return contatoDB;
            }
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);
            if (contatoDB == null)
            {
                throw new System.Exception("Houve um erro na deleção do contato");
            }
            else
            {
                _bancoContext.Contatos.Remove(contatoDB);
                _bancoContext.SaveChanges();
                return true;
            }
        }
    }
}
