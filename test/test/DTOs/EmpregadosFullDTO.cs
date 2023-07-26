using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.DTOs
{
    public class EmpregadosFullDTO
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string RGPassaporte { get; set; }
        public string MatriculaESocial { get; set; }
        public string NitPisPasep { get; set; }
        public string NomeMae { get; set; }
        public string Nacionalidade { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public DateTime Ultimo_ASO { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Sexo { get; set; }
        public string TipoSanguineo { get; set; }
        public string Cod_Categoria_eSocial { get; set; }
        public bool Ativo { get; set; }
        public string Funcao { get; set; }
        public string Setor { get; set; }
    }
}