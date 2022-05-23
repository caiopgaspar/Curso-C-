using System;
using System.IO;
namespace AulaUsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\c-gas\OneDrive\Documentos\DEV\Curso C# Completo programacao orientada a objetos e projetos\ws-vs2022\AulaFile\File1.txt";

            try
            {
                //using (FileStream fs = new FileStream(path, FileMode.Open))
                //{
                //using (StreamReader sr = new StreamReader(fs))
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                    //}
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
