﻿using System;

namespace AulaLogicos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c1 = 2 > 3 && 4 != 5; //false
            bool c2 = 2 > 3 || 4 != 5; //true
            bool c3 = !(2>3) && 4 != 5;


            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine("--------------------------------");

            bool c4 = 10 < 5;
            bool c5 = c2 || c3 && c4;

            Console.WriteLine(c4);
            Console.WriteLine(c5);



        }
    }
}
