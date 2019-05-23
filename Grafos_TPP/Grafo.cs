using System;
using System.Collections.Generic;
using System.Text;

namespace Grafos_TPP
{
    public class Grafo
    {
        public List<Vertice> grafo;

        public Grafo() { }

        public Grafo(List<Vertice> grafo)
        {
            this.grafo = grafo;
        }

        public void Imprimir()
        {
            grafo.ForEach(vertice =>
            {
                Console.Write(vertice.nome + " -> ");
                vertice.listaDeAdjacencia.ForEach(verticeNaLista =>
                {
                    if (vertice.listaDeAdjacencia.Count > 0)
                    {
                        if (vertice.listaDeAdjacencia.IndexOf(verticeNaLista) == vertice.listaDeAdjacencia.Count - 1)
                        {
                            Console.Write(verticeNaLista.nome + " -> _ ");
                        }
                        else
                        {
                            Console.Write(verticeNaLista.nome + " -> ");
                        }

                    }
                    else
                    {
                        Console.Write("->_");
                    }

                });
                Console.WriteLine();
            });
        }



    }
}
