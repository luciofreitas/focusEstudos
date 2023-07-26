using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Entities;

namespace ScreenSound.Entities
{
    class Musica
    {
        public string nome { get; set; }
        public string artista { get; set; }
        public int duracao { get; set; }

        public Musica()
        {
        }
        public Musica(string nome, string artista, int duracao)
        {
            this.nome = nome;
            this.artista = artista;
            this.duracao = duracao;
        }
        public override string ToString()
        {
            return $"Nome: {nome}\nArtista: {artista}\nDuração: {duracao} segundos";
        }

    }
}
