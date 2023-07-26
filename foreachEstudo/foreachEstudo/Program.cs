using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Lucio", "Joao", "Pedro", "Maria", "Guilherme" };

            foreach(string n in nomes)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
    }
}
