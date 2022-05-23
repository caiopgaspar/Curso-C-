using System;
using System.Globalization;
using ExerInterface.Entities;
using ExerInterface.Services;

namespace ExerInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter the number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contracts contract = new Contracts(number, date, value);

            ContractService contractService = new ContractService(new PayPalService());
            contractService.ProcessContract(contract, months);

            Console.WriteLine("Installments:");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }




        }
    }
}
