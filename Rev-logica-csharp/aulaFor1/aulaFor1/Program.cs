using System;

namespace aulaFor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;

            }
            Console.WriteLine("Soma = {0}", soma);
        }
    }
}
