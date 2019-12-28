using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoFatorial fat = new CalculoFatorial();

            Console.WriteLine("Entre com o número:");
            int x = int.Parse(Console.ReadLine());

            fat.ContadorFatorial(x);

            Console.WriteLine(fat.fatorial);
        }
    }
}
