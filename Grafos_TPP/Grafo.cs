using System;
using System.Collections.Generic;
using System.Linq;
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


        public int Heuristica1()
        {
            List<List<Vertice>> copiaGrafo = grafo;
            var pais = copiaGrafo.Select(l => l[0]).ToList();
            int cores = 0;

            while(pais.Any(v => v.cor == 0))
            {
                cores++;

                foreach(Vertice vertice in pais)
                {
                    var listaAdj = copiaGrafo.Find(lista => lista[0].materia == vertice.materia);
                    if (vertice.cor == 0 && !listaAdj.Any(v => v.materia != vertice.materia && v.cor == cores))
                    {
                        vertice.cor = cores;
                    }
                }
            }

            return cores;
        }

        public int Heuristica2()
        {
            List<List<Vertice>> copiaGrafo = grafo;
            var pais = copiaGrafo.Select(l => l[0]).ToList();
            int cores = 1;
            pais[0].cor = cores;
            for(int i = 1; i <= pais.Count; i++)
            {
                bool ok = true;
                for (int k = 1; k <= 4; k++)//cores - supondo que é um grafo planar logo máximo são 4 cores
                {
                   
                    var listaAdj = copiaGrafo.Find(lista => lista[0].materia == pais[i].materia);
                    foreach(Vertice v in listaAdj)
                    {
                        if(v.cor == k)
                        {
                            // Já há um vértice adjacente a v com essa cor. 
                            ok = false;
                        }
                    }
                    if(ok == true)
                    {
                        // Achamos uma cor que nenhum vértice adjacente a v possui.
                        pais[i].cor = k;
                    }
                }
                if(ok == false)
                {
                    // Todas as cores atuais são usadas pelos vértices adjacentes a v. 
                    cores++;
                    pais[i].cor = cores;                                     
                }
            }

            return cores;
        }

        public int Heuristica3()
        {
            List<List<Vertice>> copiaGrafo = grafo;
            // ordenar o grafo em ordem descrescente de grau
            copiaGrafo.OrderBy(materias => materias.Count);

            var pais = copiaGrafo.Select(l => l[0]).ToList();
            int cores = 0;
            while (pais.Any(v => v.cor == 0))
            {
                cores++;
                var naoColoridos = pais.Where(v => v.cor == 0);
                foreach (Vertice vertice in naoColoridos)
                {
                    // procura os adjacentes do vertice
                    var listaAdj = copiaGrafo.Find(lista => lista[0].materia == vertice.materia);//acha o pai no grafo

                    if (listaAdj.Count == 1)//quando a materia está sozinha
                    {
                        vertice.cor = cores;
                    }
                    else if (listaAdj.Any(v => v.materia != vertice.materia && v.cor != cores))// procura um vértice que não é o proprio pai e a cor dele é diferente da cor atual
                    {
                        vertice.cor = cores;
                    }

                }
            }

            return cores;
        }
      
        public void Imprimir(List<List<Vertice>> grafoImpresso)
        {
            grafoImpresso.ForEach(listaDeAdj =>
            {
                if (listaDeAdj.Count == 0)
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
