using ScreenSound.Entities;
using System.Collections.Generic;
using System;
namespace ScreenSound
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quantas musicas você pretende adicionar na sua plataforma: ");

            int n = int.Parse(Console.ReadLine());
            Plano plano = new Plano();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o nome da musica: ");
                string nome = Console.ReadLine();
                Console.Write($"Informe o artista da musica {nome}: ");
                string artista = Console.ReadLine();
                Console.Write($"Informe a duração da musica {nome}: ");
                int duracao = int.Parse(Console.ReadLine());
                Console.WriteLine($"A musica, {nome}, estará disponivel na versão gratuita do sistema? (s/n)");
                char disponivel = char.Parse(Console.ReadLine());
                Musica musica = new Musica(nome, artista, duracao);
                if (disponivel == 's'|| disponivel =='S')
                {
                    Console.WriteLine("A musica foi adicionada na lista de plano gratuito");
                    plano.AddPlanoGratuito(musica);
                }
                else
                {
                    Console.WriteLine("A musica foi adicionada na lista de plano pago");
                    plano.AddPlanoPago(musica);
                }
            }

            Console.Clear();
            
            foreach(var mGratis in plano.musicasGratis)
            {
                Console.WriteLine(mGratis);
            }            
            foreach(var mPagas in plano.musicasPagas)
            {
                Console.WriteLine(mPagas);
            }
            Console.ReadLine();
        }
    }
}
