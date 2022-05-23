using System;
using System.IO;
using System.Collections.Generic;
using AulaIComparable2.Entities;

namespace AulaIComparable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\c-gas\OneDrive\Documentos\DEV\Curso C# Completo programacao orientada a objetos e projetos\ws-vs2022\AulaIComparable2\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
