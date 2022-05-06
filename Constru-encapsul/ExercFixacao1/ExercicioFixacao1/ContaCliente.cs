using System.Globalization;

namespace ExercicioFixacao1
{
    internal class ContaCliente
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

//Construtores
        //Construtor nulo
        public ContaCliente() { }

        //Construtor 1
        public ContaCliente(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        //Construtor 2
        public ContaCliente(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
        }

//Descricao dos dados
        //ToString da Conta - descricao dos dados atualizados
        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

//Metodos
        //Metodo de deposito - adiciona valor ao saldo
        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        //Metodo de saque - desconta valor do saldo e desconta taxa de 5.00
        public void Saque(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5.00;
        }

    }
}

