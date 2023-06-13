using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos produtos voce deseja cadastrar?");
            int n = int.Parse(Console.ReadLine());
            string[] produtos = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Insire o nome do {i + 1}º produto: ");
                produtos[i] = Console.ReadLine();
            }
            //Console.Clear();
            Console.WriteLine("Produtos Listados");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(produtos[i]);
            }
            Console.ReadLine();
        }
    }
}
