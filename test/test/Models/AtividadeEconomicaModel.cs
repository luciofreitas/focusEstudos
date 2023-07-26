using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class AtividadeEconomicaModel
    {
        [Key]
        public int ID { get; set; }
        public  int Codigo { get; set; }
        public string Nome { get; set; }
        public bool Ativa { get; set; }
    }
}