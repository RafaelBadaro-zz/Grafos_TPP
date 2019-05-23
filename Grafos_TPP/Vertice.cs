using System;
using System.Collections.Generic;
using System.Text;

namespace Grafos_TPP
{
    public class Vertice
    {
        public string nome;
        public int peso;
        public List<Vertice> listaDeAdjacencia;

        public Vertice(){}

        public Vertice(string nome, int peso, List<Vertice> listaDeAdjacencia)
        {
            this.nome = nome;
            this.peso = peso;
            this.listaDeAdjacencia = listaDeAdjacencia;
        }
    }
}
