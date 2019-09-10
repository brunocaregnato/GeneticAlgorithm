using System;
using System.Collections.Generic;
using System.Text;

namespace EmpilhadeiraAutoguiada
{
    class Population
    {
        private int PopulationSize { get; set; }
        public Forklift[] Forklift { get; set; }

        public Population(int geneNumbers, int populationSize)
        {
            PopulationSize = populationSize;
            Forklift = new Forklift[populationSize];
            for (int i = 0; i < Forklift.Length; i++)
            {
                Forklift[i] = new Forklift(geneNumbers);
            }

        }
    }
}
