using System;
using System.IO;

namespace AulaFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\c-gas\OneDrive\Documentos\DEV\Curso C# Completo programacao orientada a objetos e projetos\ws-vs2022\AulaFile\file1.txt";
            string targetPath =@"C:\Users\c-gas\OneDrive\Documentos\DEV\Curso C# Completo programacao orientada a objetos e projetos\ws-vs2022\AulaFile\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
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
