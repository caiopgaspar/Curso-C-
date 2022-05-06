using System;
using System.Globalization;

namespace ExercicioCondicionais7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double X = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double Y = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (X == 0 && Y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (X == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (Y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
