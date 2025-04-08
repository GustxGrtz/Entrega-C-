using System;
using System.Globalization;

namespace sistemaDeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            do
            {
                Console.WriteLine("1 - nome e salve");
                Console.WriteLine("2 - idade");
                Console.WriteLine("3 - média das notas");
                Console.WriteLine("4 - maior número");
                Console.WriteLine("5 - par ou impar");
                Console.WriteLine("6 - sair");
                Console.Write("fala ai o numero da opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Exe1.Executar();
                        break;

                    case 2:
                        Exe2.Executar();
                        break;

                    case 3:
                        Exe3.Executar();
                        break;

                    case 4:
                        Exe4.Executar();
                        break;

                    case 5:
                        Exe5.Executar();
                        break;

                    case 6:
                        Console.WriteLine("é isso então, flw");
                        break;

                    default:
                        Console.WriteLine("nao tem essa opção kkk tenta dnv");
                        break;
                }

                Console.WriteLine("");
            }
            while (escolha != 6);
        }
    }
}
