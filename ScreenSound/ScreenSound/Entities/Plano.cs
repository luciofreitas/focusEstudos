using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Entities
{
    class Plano
    {
        public string nome { get; set; }
        public char disponivel { get; set; }
        public List<Musica> musicasGratis { get; set; } = new List<Musica>();
        public List<Musica> musicasPagas  { get; set; } = new List<Musica>();
        public Plano()
        {
        }
        public Plano(string nome, char disponivel)
        {
            this.nome = nome;
            this.disponivel = disponivel;
        }
        public void AddPlanoGratuito(Musica musica)
        {
            musicasGratis.Add(musica);
        }
        public void AddPlanoPago(Musica musica)
        {
            musicasPagas.Add(musica);
        }
        public override string ToString()
        {
            string resultado = $"Nome do plano: {nome}\nDisponível: {disponivel}\n";

            resultado += "Músicas grátis:\n";
            foreach (var musica in musicasGratis)
            {
                resultado += $"{musica.ToString()}\n";
            }

            resultado += "Músicas pagas:\n";
            foreach (var musica in musicasPagas)
            {
                resultado += $"{musica.ToString()}\n";
            }

            return resultado;
        }
    }
}
