using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exibirMaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2;
            Console.Write("Valor1: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.Write("Valor2: ");
            valor2 = int.Parse(Console.ReadLine());

            if(valor1 > valor2)
            {
                Console.WriteLine($"O primeiro valor que é {valor1} é maior");
            }
            else
            {
                Console.WriteLine($"O segundo valor que é {valor2} é maior");
            }
            Console.ReadLine();
        }
    }
}
