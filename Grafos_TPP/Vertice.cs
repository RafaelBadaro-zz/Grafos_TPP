using System;
using System.Collections.Generic;
using System.Text;

namespace Grafos_TPP
{
    public class Vertice
    {

        public string professor;
        public string materia;
        public int periodo;
        public string cor;

        public Vertice(){}

        public Vertice(string professor, string materia, int periodo, string cor)
        {
            this.professor = professor;
            this.materia = materia;
            this.periodo = periodo;
            this.cor = cor;
        }
    }
}
