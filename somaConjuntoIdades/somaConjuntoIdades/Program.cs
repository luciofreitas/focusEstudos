using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somaConjuntoIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de idades voce quer que some: ");
            int n = int.Parse(Console.ReadLine());

            int[] idades = new int[n];

            for (int i = 0; i < idades.Length; i++)
            {
                Console.Write($"Informe a {i + 1}ª idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                sum += idades[i];
            }
            Console.WriteLine($"A soma das {n} idade é igual a: {sum}");

            Console.ReadLine();
        }
    }
}
