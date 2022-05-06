using System;

namespace exercicioFor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero entre 1 e 1000: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
