using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FocusHealthSolutionsTeste1.Models
{
    public class PlanilhaModel
    {
        public DateTime Agendado_Em { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Ficha { get; set; }
        public string Parceiro { get; set; }
        public string Colaborador { get; set; }
        public string Natureza { get; set; }
        public DateTime Agendado_Para { get; set; }
        public bool Conf { get; set; }
        public bool Pres { get; set; }
        public bool ASO_Up { get; set; }
        public bool ASO_Prot { get; set; }
        public bool Pend { get; set; }
        public bool Tem_Av { get; set; }
        public bool Tem_Res { get; set; }
    }
}
