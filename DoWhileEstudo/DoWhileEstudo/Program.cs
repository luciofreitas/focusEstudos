using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            do
            {
                Console.WriteLine("Rodando o do-while uma vez, mesmo a condição sendo falsa !");
                contador++;
            } while (contador > 20);
            Console.ReadLine();
        }
    }
}
