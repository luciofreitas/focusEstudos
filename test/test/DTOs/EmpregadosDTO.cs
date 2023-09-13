using System;

namespace test.DTOs
{
    public class EmpregadosDTO
    {
        public int ID { get; set; }
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RGPassaporte { get; set; }
        public string MatriculaESocial { get; set; }
        public string NitPisPasep { get; set; }
        public string NomeMae { get; set; }
        public string Nacionalidade { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Sexo { get; set; }
        public string TipoSanguineo { get; set; }
        public string CodCategoriaeSocial { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime UltimoASO { get; set; }
        public string NomeSetor { get; set; }
        public string NomeSetorIngles { get; set; }       
        public string NomeFuncao { get; set; }
        public string NomeFuncaoIngles { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string AtividadeEconomica { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public bool Ativo { get; set; }
    }
}