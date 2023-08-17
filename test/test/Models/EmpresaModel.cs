using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class EmpresaModel
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
        public int Atividade_Economica_ID { get; set; }
        public int Cidade_ID { get; set; }
        public bool Ativa { get; set; }
    }
}