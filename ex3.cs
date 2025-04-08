using System;
using System.Globalization;

namespace sistemaDeAluno
{
    public class Exe3
    {
        public static void Executar()
        {
            Console.Write("primeira nota: ");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("segunda nota: ");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("terceira nota: ");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (n1 + n2 + n3) / 3;
            Console.WriteLine("média deu: " + media.ToString("F2"));
        }
    }
}
