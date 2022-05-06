using System;
using System.Globalization;

namespace ExercicioFixacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCliente cliente = new ContaCliente();
            
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine()); //variavel auxiliar temporaria
            Console.Write("Entre o titular da conta: "); 
            string titular = Console.ReadLine();        //idem
            Console.Write("Havera deposito inicial? (s/n) ");
            char resp = char.Parse(Console.ReadLine());  //idem

            if(resp == 's' || resp == 'S')
            {
                Console.Write("Entre o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente = new ContaCliente(numero, titular, depositoInicial); //instanciando a conta caso tenha deposito inicial
            }
            else
            {
                cliente = new ContaCliente(numero, titular); //instanciando a conta caso nao tenha deposito inicial
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cliente); //mostrar os dados atualizados usando o ToString da conta

            Console.WriteLine();
            Console.Write("Entre o valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //pegando o valor do deposito
            cliente.Deposito(quantia); //utilizando o metodo para adicionar o valor do deposito ao saldo
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);

            Console.WriteLine();
            Console.Write("Entre o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //pegando o valor do saque
            cliente.Saque(quantia); //utilizando o metodo para descontar o valor do saque do saldo
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);





        }
    }
}
