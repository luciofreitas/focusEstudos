using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumEstudo
{
    class Program
    {
        enum Cor
        {
            Azul,
            Verde,
            Amarelo,
            Vermelho
        }
        static void Main(string[] args)
        {
            Cor corFavorita = Cor.Vermelho;
            Console.WriteLine(corFavorita);

            Console.ReadLine();
        }
    }
}
