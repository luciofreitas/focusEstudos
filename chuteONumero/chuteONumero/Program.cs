using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuteONumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numeroAleatorio = new Random();
            int valor = numeroAleatorio.Next(1,10);

            Console.Write("Informe o numero que voce julga ser o que vai sair: ");
            int valorEntrada = int.Parse(Console.ReadLine());
            Console.WriteLine($"O valor sorteado foi: {valor} ");
            while (valorEntrada != valor)
            {               
                Console.WriteLine("Que pena tente de novo.");
                if (valorEntrada > valor)
                {                   
                    Console.WriteLine($"O valor foi {valorEntrada - valor} acima do sorteado");
                }
                else if (valorEntrada == valor)
                {
                    Console.WriteLine("Oba, voce acertou o numero");
                    Console.ReadLine();
                }
                else
                {                   
                    Console.WriteLine($"Valor foi {valor - valorEntrada} abaixo do sorteado");
                }
                Console.Write("Informe o numero que voce julga ser o que vai sair de novo: ");
                valorEntrada = int.Parse(Console.ReadLine());
                valor = numeroAleatorio.Next(10);
                Console.WriteLine($"O valor sorteado foi: {valor} ");
            }
            Console.ReadLine();
        }
    }
}
