using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class CidadeEstadoDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Estado_ID { get; set; }
        public string NomeEstado { get; set; }
    }
}