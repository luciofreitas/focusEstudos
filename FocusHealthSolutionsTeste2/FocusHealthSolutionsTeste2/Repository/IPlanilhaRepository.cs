using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FocusHealthSolutionsTeste2.Models;

namespace FocusHealthSolutionsTeste2.Repository
{
    public interface IPlanilhaRepository
    {
        PlanilhaModel BuscarPorFicha(string ficha);
        List<PlanilhaModel> BuscarTodos();
        PlanilhaModel Atualizar(PlanilhaModel dados);
    }
}
