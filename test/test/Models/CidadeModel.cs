using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class CidadeModel
    {
        [Key]
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Estado_ID { get; set; }
    }
}