using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigurasGeometricas.Entities
{
    class Menu
    {
        public char op { get; set; }
        public Menu()
        {

        }

        public Menu(char op)
        {
            this.op = op;
        }
        public static void ItemsMenu()
        {
            Console.WriteLine("Por favor digite a area de qual figura você deseja calcular");
            Console.WriteLine("1 - Quadrado");
            Console.WriteLine("2 - Retangulo");
            Console.WriteLine("3 - Triangulo");
            Console.WriteLine("4 - Losango");
            Console.WriteLine("5 - Circulo");
            Console.WriteLine("6 - Sair");
            char op = char.Parse(Console.ReadLine());
            switch (op)
            {
                case '1':
                    Console.WriteLine("Informe a base do quadrado: ");
                    float bQ = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura do quadrado: ");
                    float aQ = float.Parse(Console.ReadLine());
                    float areaQ = bQ * aQ;
                    Console.WriteLine($"A area do quadrado é igual a {areaQ}");
                    break;
                case '2':
                    Console.WriteLine("Informa a base do retangulo: ");
                    float bR = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura do retangulo: ");
                    float aR = float.Parse(Console.ReadLine());
                    float areaR = bR * aR;
                    Console.WriteLine($"A area do retangulo é igual a {areaR}");
                    break;
                case '3':
                    Console.WriteLine("Informa a base do triangulo: ");
                    float bT = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura do triangulo: ");
                    float aT = float.Parse(Console.ReadLine());
                    float areaT = (bT * aT) / 2;
                    Console.WriteLine($"A area do retangulo é igual a {areaT}");
                    break;
                case '4':
                    Console.WriteLine("Informa a diagonal maior do losango: ");
                    float dMaiorL = float.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a diagonal menor do losango: ");
                    float dMenorL = float.Parse(Console.ReadLine());
                    float areaL = dMaiorL * (2 * dMenorL);
                    Console.WriteLine($"A area do losango é igual a {areaL}");
                    break;
                case '5':
                    double pi = 3.14159265358979323846;
                    Console.WriteLine("Informa o raio do circulo: ");
                    double rC = double.Parse(Console.ReadLine());
                    double areaC = pi * Math.Pow(rC, 2);
                    Console.WriteLine($"A area do circulo é igual a {Math.Round(areaC, 2)}");
                    break;
            }
            Console.ReadLine();
        }
    }
}
