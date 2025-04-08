using System;

namespace sistemaDeAluno
{
    public class Exe4
    {
        public static void Executar()
        {
            Console.Write("digita o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("digita o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("maior é: " + num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("maior é: " + num2);
            }
            else
            {
                Console.WriteLine("iguais fi");
            }
        }
    }
}
