namespace ExFixacaoClasses
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double ValorReais(double cotacao, double valorDolares)
        {
            double total = cotacao * valorDolares;
            return total + total * Iof;
        }


    }
}
