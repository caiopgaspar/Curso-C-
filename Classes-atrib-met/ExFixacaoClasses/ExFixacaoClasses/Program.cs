using System;
using System.Globalization;

namespace ExFixacaoClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual e a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares voce vai comprar? ");
            double valorDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.ValorReais(cotacao, valorDolares);

            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
