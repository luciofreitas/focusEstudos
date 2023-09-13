using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class SetorModel
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nome_Ingles { get; set; }
        public bool Ativo { get; set; }
    }
}