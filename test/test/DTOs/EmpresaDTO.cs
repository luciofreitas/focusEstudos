using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.DTOs
{
    public class EmpresaDTO
    {
        public int ID { get; set; }
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
        [DisplayName("Número de empregados")]
        public int NumeroEmpregados { get; set; }
        [DisplayName("CNAE")]
        public string CNAE { get; set; }
        [DisplayName("Data de Cadastro")]
        public DateTime Data_Cadastro { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        [DisplayName("Complemento")]
        public string Complemento { get; set; }
        [DisplayName("Bairro")]
        public string Bairro { get; set; }
        [DisplayName("CEP")]
        public string CEP { get; set; }
        [DisplayName("Atividade Econômica")]
        public string Atividade_Economica { get; set; }
        [DisplayName("Cidade")]
        public string Cidade { get; set; }
        [DisplayName("Ativa")]
        public bool Ativa { get; set; }
    }
}