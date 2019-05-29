using System;
using System.Collections.Generic;
using System.IO;

namespace Grafos_TPP
{
    public class Program
    {
        /*
          Estrutura de representação - lista de adjacência
             Problema: Considere que você seja o responsável por elaborar o horário de aulas do curso de
                        Engenharia de Software da PUC Minas. O problema, nesse caso, consiste em alocar os
                        horários de cada turma do curso de forma a maximizar o número de turmas ofertadas em
                        paralelo. Para isso, é necessário respeitar a designação dos professores às suas
                        respectivas turmas. Considere também que alguns professores ministram aulas para
                        diversas turmas e que, por dia, possamos ter, no máximo, três horários de aula.

                        Além disso, lembre-se que turmas do mesmo período não podem ser alocadas no
                        mesmo horário; que uma turma só pode ser alocada a um professor; e que um mesmo
                        professor não pode lecionar para mais de uma turma em um dado horário.

            Resolução : coloração de arestas com grafo bipartido
            Vértices: Professor
            Arestas: Existirá aresta se o professor lecionar a aula
        */

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
