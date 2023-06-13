using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSwitchEstudo
{
    class Program
    {
        enum Opcao
        {
            Criar=1,
            Deletar=2,
            Editar=3,
            Listar=4,
            Atualizar=5
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma das opções abaixo");
            Console.WriteLine("1 - Criar\n2 - Deletar\n3 - Editar\n4 - Listar\n5 - Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;
            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Criando...");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("Deletando...");
                    break;
                case Opcao.Editar:
                    Console.WriteLine("Editando...");
                    break;
                case Opcao.Listar:
                    Console.WriteLine("Listando...");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Atualizando...");
                    break;
            }

            Console.ReadLine();
        }
    }
}
