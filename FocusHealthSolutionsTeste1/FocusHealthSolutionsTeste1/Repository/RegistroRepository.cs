using FocusHealthSolutionsTeste1.Data;
using FocusHealthSolutionsTeste1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FocusHealthSolutionsTeste1.Repository
{
    public class RegistroRepository : IRegistroRepository
    {
        private readonly BancoContext _bancoContext;
        public RegistroRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public PlanilhaModel Adicionar(PlanilhaModel dados)
        {
            _bancoContext.Planilha.Add(dados);
             _bancoContext.SaveChanges();

            return dados;
        }
    }
}
