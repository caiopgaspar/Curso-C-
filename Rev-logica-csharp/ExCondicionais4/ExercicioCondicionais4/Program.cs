using System;

namespace ExercicioCondicionais4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int inicio = int.Parse(valores[0]);
            int final = int.Parse(valores[1]);

            int duracao;

            if (inicio < final)
            {
                duracao = final - inicio;
            }
            else
            {
                duracao = 24 - inicio + final;
            }

            Console.WriteLine("O JOGO DUROU {0} HORA(S)", duracao);

            

        }
    }
}
