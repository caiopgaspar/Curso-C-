using System;
using System.Globalization;

namespace ExercicioSequencial4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valor;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
            


        }
    }
}
