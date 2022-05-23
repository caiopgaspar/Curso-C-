using System;
using System.IO;
using System.Collections.Generic;

namespace AulaDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\c-gas\OneDrive\Documentos\DEV\Curso C# Completo programacao orientada a objetos e projetos\ws-vs2022\AulaDirectory\myfolder";
            try
            {
                //IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                foreach(string item in folders)
                {
                    Console.WriteLine(item);
                }
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                foreach (string item in files)
                {
                    Console.WriteLine(item);
                }

                Directory.CreateDirectory(path + "\\newfolder");

            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
