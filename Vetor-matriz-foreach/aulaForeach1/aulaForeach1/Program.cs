using System;

namespace aulaForeach1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            /*
            for(int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }
            */

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
