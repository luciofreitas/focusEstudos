using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.DTOs
{
    public class EmpresaDTO
    {
        public int ID { get; set; }
        public string RazaoSocial { get; set; }
        public int NumeroEmpregados { get; set; }
        public string CNAE { get; set; }
        public DateTime Data_Cadastro { get; set; }
        public string Observacao { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public string Atividade_Economica { get; set; }
        public string Cidade { get; set; }
    }
}