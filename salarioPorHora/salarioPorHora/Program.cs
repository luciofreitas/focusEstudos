using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarioPorHora 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe seu nome, por favor: ");
            string nome = Console.ReadLine();

            Console.Write("Informe seu salario mensal: ");
            double salarioMensal = double.Parse(Console.ReadLine());

            Console.Write("Informe sua carga horária: ");
            int hora = int.Parse(Console.ReadLine());

            double salarioPorHora = salarioMensal / (double)hora;

            Console.WriteLine($"O salario por hora do {nome} é igual a R${salarioPorHora}");

            Console.ReadLine();
        }
    }
}
