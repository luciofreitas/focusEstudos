using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm_1
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public Contato()
        {
        }
        public Contato(int id, string nome,int telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}