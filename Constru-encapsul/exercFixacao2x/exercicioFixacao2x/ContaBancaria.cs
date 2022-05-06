using System.Globalization;

namespace exercicioFixacao2x
{
    internal class ContaBancaria
    {
        public int Numero{ get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria (int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public ContaBancaria (int numero, string nome, double saldo) : this (numero, nome)
        {
            Saldo = saldo;
        }

        // Mecanismos

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.0;
        }

        //ToString

        public override string ToString()
        {
            return "Conta " 
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
