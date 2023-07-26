using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class EstadoModel
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Siglas { get; set; }
    }
}