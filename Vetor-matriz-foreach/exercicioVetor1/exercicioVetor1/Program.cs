using System;

namespace exercicioVetor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] aluguel = new Aluguel[10];

            Console.Write("Quantos quartos serao alugados? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                aluguel[quarto] = new Aluguel (nome, email);
            }

            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < 10; i++)
            {
                if (aluguel[i] != null)
                {
                    Console.WriteLine(i + ": " + aluguel[i]);
                }
            }
        }
    }
}
