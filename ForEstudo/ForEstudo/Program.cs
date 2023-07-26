using System;

namespace ForEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos dados colocará na lista");
            int n = int.Parse(Console.ReadLine());
            string[] nomes = new string[n];
            for(int i=0; i<n; i++)
            {
                Console.Write($"Insira o {i+1}º item: ");
                nomes[i] = Console.ReadLine();
            }
            //Console.Clear();
            Console.WriteLine("Itens adicionados na lista:");
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
            Console.ReadLine();
        }
    }
}
