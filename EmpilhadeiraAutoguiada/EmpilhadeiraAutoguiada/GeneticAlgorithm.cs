using System;
using System.Collections.Generic;
using System.Text;

namespace EmpilhadeiraAutoguiada
{
    class GeneticAlgorithm
    {
        public float MutationRate { get; set; }
        public float CrossoverRate { get; set; }
        public int genesNumbers { get; set; }
        public List<string> Possibilities { get; set; }

        public GeneticAlgorithm()
        {
            Possibilities = new List<string>
            {
                "South",
                "North",
                "West",
                "East"
            };
        }

    }
}
