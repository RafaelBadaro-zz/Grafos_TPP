using System;
using System.Collections.Generic;
using System.Text;

namespace Grafos_TPP
{
    public class Grafo
    {        
        public List<List<Vertice>> grafo;

        public Grafo() { }

        public Grafo(List<List<Vertice>> grafo)
        {
            this.grafo = grafo;
        }


        //public List<Vertice> heuristica1()
        //{

        //}

        //public List<Vertice> heuristica2()
        //{

        //}

        //public List<Vertice> heuristica3()
        //{

        //}

        public void Imprimir()
        {
            grafo.ForEach(listaDeAdj =>
            {
                if(listaDeAdj.Count == 0)
                {
                    Console.WriteLine("-> _");
                }
                else
                {
                    listaDeAdj.ForEach(vertice =>
                    {
                        if (listaDeAdj.IndexOf(vertice) == listaDeAdj.Count - 1)
                        {
                            Console.Write(vertice.professor + "/" + vertice.materia + "/" + vertice.periodo + " ->_ ");
                        }
                        else
                        {
                            Console.Write(vertice.professor + "/" + vertice.materia + "/" + vertice.periodo + " -> ");
                        }

                    });
                    Console.WriteLine();
                }
            });
        }


    }
}
