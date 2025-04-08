using System;

namespace sistemaDeAluno
{
    public class Exe5
    {
        public static void Executar()
        {
            Console.Write("digita um numero ai: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("esse é par");
            }
            else
            {
                Console.WriteLine("esse é impar");
            }
        }
    }
}
