using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.DTOs
{
    public class EmpregadosDTO
    {
        public int ID { get; set; }
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG_Passaport { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public DateTime Ultimo_ASO { get; set; }
        public string Nome_Setor { get; set; }
        public string Nome_Setor_Ingles { get; set; }       
        public string Nome_Funcao { get; set; }
        public string Nome_Funcao_Ingles { get; set; }
        public string Razao_Social { get; set; }
        public string CNPJ { get; set; }
        public string Atividade_Economica { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}