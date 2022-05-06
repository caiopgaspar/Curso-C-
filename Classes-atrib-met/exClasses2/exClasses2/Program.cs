using System;
using System.Globalization;

namespace exercicioClasses2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionario: " + funcionario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados " + funcionario);


        }
    }
}