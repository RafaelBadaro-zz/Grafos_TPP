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

            Resolução : coloração de vértices
            Vértices: materia/turma
            Arestas: conflitos(mesmo professor ou período)
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
            Grafo g = new Grafo(new List<List<Vertice>>());
            List<Vertice> a = new List<Vertice>();
            List<Vertice> b = new List<Vertice>();

            a.Add(new Vertice("profa","materiaA", 1));
            a.Add(new Vertice("profa2", "materiaA2", 1));
            b.Add(new Vertice("profb", "materiaB", 1));
            b.Add(new Vertice("profb2", "materiaB2", 1));

            g.grafo.Add(a);
            g.grafo.Add(b);

            g.Imprimir();
        }
    }
}
