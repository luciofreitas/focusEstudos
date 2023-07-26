using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FocusHealthSolutionsTeste1.Models;

namespace FocusHealthSolutionsTeste1.Repository
{
    public interface IPlanilhaRepository
    {
        PlanilhaModel BuscarPorFicha(string ficha);
        List<PlanilhaModel> BuscarTodos();
        PlanilhaModel Atualizar(PlanilhaModel dados);
    }
}
