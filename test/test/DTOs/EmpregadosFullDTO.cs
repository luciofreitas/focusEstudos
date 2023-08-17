using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Umbraco.Core.Models.Entities;

namespace test.DTOs
{
    public class EmpregadosFullDTO
    {
        //private string nome;
        public int ID { get; set; }

        [DisplayName("CPF")]
        public string CPF { get; set; }

        [DisplayName("Empresa")]
        public string Empresa { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("RG ou Passaporte")]
        public string RGPassaporte { get; set; }

        [DisplayName("Matricula eSocial")]
        public string MatriculaESocial { get; set; }

        [DisplayName("Nit ou Pis ou Pasep")]
        public string NitPisPasep { get; set; }

        [DisplayName("Nome da Mãe")]
        public string NomeMae { get; set; }

        [DisplayName("Nacionalidade")]
        public string Nacionalidade { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime? Data_Nascimento { get; set; }

        [DisplayName("Ultimo ASO Cadastrado")]
        public DateTime? Ultimo_ASO { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage ="O email é requerido")]
        public string Email { get; set; }

        [DisplayName("Celular")]
        public string Celular { get; set; }

        [DisplayName("Sexo")]
        public string Sexo { get; set; }

        [DisplayName("Tipo Sanguineo")]
        public string TipoSanguineo { get; set; }

        [DisplayName("Codigo da Categoria eSocial")]
        public string Cod_Categoria_eSocial { get; set; }

        [DisplayName("Ativo")]
        public bool Ativo { get; set; }

        [DisplayName("Função")]
        public string Funcao { get; set; }

        [DisplayName("Setor")]
        public string Setor { get; set; }
        
        //protected String RemoveEspacos( string texto)
        //{
        //    if(texto != null)
        //    {
        //        Regex regex = new Regex(@"\s{2,}");
        //        return regex.Replace(texto.Trim(), " ");
        //    }
        //    else
        //    return string.Empty;
        //}

    }
}