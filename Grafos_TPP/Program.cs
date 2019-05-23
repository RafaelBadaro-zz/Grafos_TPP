using System;
using System.Collections.Generic;
using System.IO;

namespace Grafos_TPP
{
    public class Program
    {

        public void LerArquivo() // Lê arquivo e cria vagas se nescessario.
        {
            if (File.Exists(@"C:"))
            {
                using (StreamReader reader = new StreamReader(@"C:"))
                {

                    while (!reader.EndOfStream) // Enquanto arquivo não acaba.
                    {
                        string linha = reader.ReadLine();
                    }
                }
            }
        }

        //------------------ Main
        public static void Main(string[] args)
        {

        }
    }
}
