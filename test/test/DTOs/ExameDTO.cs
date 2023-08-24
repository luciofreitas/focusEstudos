using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace test.DTOs
{
    public class ExameDTO
    {
        public int ID { get; set; }
        [DisplayName("Nome")]
        public string Nome_Exame { get; set; }
        [DisplayName("Nome em Ingles")]
        public string Nome_Exame_Ingles { get; set; }
        [DisplayName("Nome Laboratorial")]
        public string Nome_Laboratorial { get; set; }
        [DisplayName("MNE Solicitação")]
        public string MNE_Solicitacao { get; set; }
        [DisplayName("Tipo Resultado")]
        public string Tipo_Resultado { get; set; }
        [DisplayName("Exame para Custo")]
        public string Exame_Custo { get; set; }
        [DisplayName("Cod.eSocial")]
        public string Cod_Categoria_eSocial { get; set; }
        [DisplayName("Unidade de medida")]
        public string Unidade_Medida { get; set; }
        [DisplayName("Parametros de Normalidade")]
        public string Parametro_Normalidade { get; set; }
        public float Valor { get; set; }
        public byte[] Arquivo { get; set; }
        public bool Tipo { get; set; }
        public bool Masculino { get; set; }
        public bool Feminino { get; set; }
        public bool ExibFicha { get; set; }
        public bool ExibASO { get; set; }
        public bool Ativo { get; set; }
        public string Empresa { get; set; }
        public string Cidade { get; set; }
    }
}