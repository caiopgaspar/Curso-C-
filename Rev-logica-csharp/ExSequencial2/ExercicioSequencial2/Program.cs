using System;
using System.Globalization;

namespace ExercicioSequencial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;
            
            Console.Write("Digite a medida do raio do circulo: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            


        }
    }
}
