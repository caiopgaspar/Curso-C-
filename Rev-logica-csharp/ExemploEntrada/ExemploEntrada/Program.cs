using System;

namespace ExemploEntrada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
           
            string s = Console.ReadLine();
            string[] v = s.Split(' ');

            // ou, para ficar mais simples, diretamente:
            // string[] v = Console.ReadLine().Split(' ');

            string a = v[0], b = v[1], c = v[2];

            Console.WriteLine("Voce digitou:");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
                

        }
    }
}
