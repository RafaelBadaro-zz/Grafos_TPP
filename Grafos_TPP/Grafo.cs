using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Grafos_TPP
{
    public class Grafo
    {        
        public List<List<Vertice>> grafo;
        public string[] cores = new string[] { "Azul", "Vermelho", "Verde", "Amarelo" };

        public Grafo() { }

        public Grafo(List<List<Vertice>> grafo)
        {
            this.grafo = grafo;
        }


        //public List<Vertice> WelshEPowell()
        //{
        //}

        public List<List<Vertice>> heuristica2()
        {
            List<List<Vertice>> copiaGrafo = grafo;
            // ordenar o grafo em ordem descrescente de grau
            copiaGrafo.OrderBy(materias => materias.Count);

            var pais = copiaGrafo.Select(l => l[0]).ToList();
            int cont = 0;
            string cor = cores[cont];
            while (pais.Any(v => v.cor == null))
            {
                cont++;
                var naoColoridos = pais.Where(v => v.cor == null);
                foreach (Vertice vertice in naoColoridos)
                {
                    // procura os adjacentes do vertice
                    var listaAdj = copiaGrafo.Find(lista => lista[0].materia == vertice.materia);//acha o pai no grafo
                   
                    if (listaAdj.Any(v => v.materia != vertice.materia && v.cor != cor))// procura um vértice que não é o proprio pai e a cor dele é diferente da cor atual
                    {
                        vertice.cor = cor;
                    }

                }
                
                if(cont > cores.Length)
                {
                    cont = 0;
                }
                cor = cores[cont];
            }



            return copiaGrafo;
        }

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
