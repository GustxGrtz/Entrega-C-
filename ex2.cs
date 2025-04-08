using System;

namespace sistemaDeAluno
{
    public class Exe2
    {
        public static void Executar()
        {
            Console.Write("qual ano tu nasceu? ");
            int ano = int.Parse(Console.ReadLine());
            int idade = 2024 - ano;
            Console.WriteLine("tu tem " + idade + " anos");
        }
    }
}
