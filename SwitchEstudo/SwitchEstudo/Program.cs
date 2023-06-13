using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchEstudo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual cor você escolhe?");
            Console.WriteLine("1 - Verde");
            Console.WriteLine("2 - Vermelho");
            Console.WriteLine("3 - Violeta");
            char op = char.Parse(Console.ReadLine());
            //Console.Clear();
            switch (op)
            {
                case '1':
                    Console.WriteLine("Você escolheu a cor verde");
                    break;
                case '2':
                    Console.WriteLine("Você escolheu a cor vermelha");
                    break;
                case '3':
                    Console.WriteLine("Você escolheu a cor violeta");
                    break;
            }
            Console.ReadLine();
        }
    }
}
