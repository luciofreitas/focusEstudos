using FocusHealthSolutionsTeste2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FocusHealthSolutionsTeste2.Models;

namespace FocusHealthSolutionsTeste2.Repository
{
    public class PlanilhaRepository : IPlanilhaRepository
    {
        private readonly BancoContext _bancoContext;
        public PlanilhaRepository(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public PlanilhaModel Atualizar(PlanilhaModel dados)
        {
            PlanilhaModel dbDados = BuscarPorFicha(dados.Ficha);
            if (dbDados == null)
            {
                throw new Exception("Houve um erro na atualização da informação");
            }
            else
            {
                //  dbDados.Ficha = dados.Ficha; não vai poder editar ficha
                //  dbDados.Agendado_Em = dados.Agendado_Em; não vai poder editar agendado em
                dbDados.Parceiro = dados.Parceiro;
                dbDados.Colaborador = dados.Colaborador;
                dbDados.Natureza = dados.Natureza;
                dbDados.Agendado_Para = dados.Agendado_Para;
                dbDados.Conf = dados.Conf;
                dbDados.Pres = dados.Conf;
                dbDados.ASO_Up = dados.ASO_Up;
                dbDados.Pend = dados.Pend;
                dbDados.Tem_Av = dados.Tem_Av;
                dbDados.Tem_Res = dados.Tem_Res;
                _bancoContext.Update(dbDados);
                _bancoContext.SaveChanges();
                return dbDados;
            }
        }

        public PlanilhaModel Atualizar()
        {
            throw new NotImplementedException();
        }

        public PlanilhaModel BuscarPorFicha(string ficha)
        {
            return _bancoContext.Planilha.FirstOrDefault(x => x.Ficha == ficha);
        }
        public List<PlanilhaModel> BuscarTodos()
        {
            return _bancoContext.Planilha.ToList();
        }
    }
}
