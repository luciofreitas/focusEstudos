using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.DTOs
{
    public class Exame_TabeladoDTO
    {
        public int ID { get; set; }
        public string NomeExame_ExameTabelado { get; set; }
        public string Empresa_ExameTabelado { get; set; }
        public float Valor_ExameTabelado { get; set; }
    }
}