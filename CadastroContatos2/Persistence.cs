using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroContatos2.Models;

namespace CadastroContatos2
{
    public class Persistence
    {
        private List<ContatoModel> data; 

        public Persistence()
        {
            data = new List<ContatoModel>();
        }

        // Método para criar um novo registro
        public void Create(ContatoModel model)
        {
            data.Add(model);
        }

        // Método para ler todos os registros
        public List<ContatoModel> ReadAll()
        {
            return data.ToList();
        }

        // Método para ler um registro por ID
        public ContatoModel ReadById(int id)
        {
            return data.FirstOrDefault(x => x.Id == id);
        }

        // Método para atualizar um registro
        public void Update(ContatoModel model)
        {
            var existingModel = data.FirstOrDefault(x => x.Id == model.Id);
            if (existingModel != null)
            {
                existingModel.Nome = model.Nome;
                existingModel.Email = model.Email;
                existingModel.Celular = model.Celular;

            }
        }
        // Método para excluir um registro
        public void Delete(ContatoModel model)
        {
            data.Remove(model);
        }
    }
}
