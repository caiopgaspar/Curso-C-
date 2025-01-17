﻿using System;
using System.IO;

namespace AulaFileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\c-gas\OneDrive\Documentos\DEV\Curso C# Completo programacao orientada a objetos e projetos\ws-vs2022\AulaFile\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //sr = new StreamReader(fs);
                sr  = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                //string line = sr.ReadLine();
                //Console.WriteLine(line);
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if(fs != null) fs.Close();
            }
        }
    }
}
