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


        //public List<Vertice> WelshEPowell()
        //{
        //}

        public void heuristica2()
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

            MontarGrade(copiaGrafo);
        }

        //public List<Vertice> heuristica3()
        //{

        //}


        public void MontarGrade(List<List<Vertice>> grafoColorado)
        {
            /*
             Formato:
             N - periodo
             turma - prof,           
             */

            //Primeiro descobrir quantos periodos tem

           var periodos = grafoColorado.SelectMany(l => l.Select(v => v.periodo)).Distinct().ToList();
            periodos.Sort();

            for(int i = 1; i <= periodos.Count; i++)
            {
                Console.WriteLine(i + "-Período");
                var materiasPorPeriodo = grafoColorado.Select(l => l.Where(v => v.periodo == i).ToList()).ToList();

                List<List<Vertice>> filtragem = new List<List<Vertice>>();// grafo com todas as matérias do período sem repetição
                materiasPorPeriodo.ForEach(l =>
                {
                    if(l.Count > 0)
                    {
                        if (filtragem.Where(lista => lista[0].materia == l[0].materia).Count() == 0)
                        {
                            filtragem.Add(l);
                        }
                    }
                });

                //São sempre 3 horários:
                // Pegar essas materias(Filtragem) e permutar em 3 horários
                

                Imprimir(filtragem);



               


                Console.WriteLine("--------------------------");
            }



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
