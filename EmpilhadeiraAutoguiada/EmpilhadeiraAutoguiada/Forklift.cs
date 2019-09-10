using System;
using System.Collections.Generic;
using System.Text;

namespace EmpilhadeiraAutoguiada
{
    class Forklift
    {
        private GeneticAlgorithm GeneticAlgorithm { get; set; }
        private List<string> Directions { get; set; } = new List<string>();
        private int Aptitude { get; set; }

        public Forklift(int genesNumbers)
        {
            GeneticAlgorithm = new GeneticAlgorithm();

            List<string> possibilities = GeneticAlgorithm.Possibilities;
            Random random = new Random();

            for (int i = 0; i < genesNumbers; i++)
            {
                //gera as possibilidades
                Directions.Add(possibilities[random.Next(4)]);

            }

            //criar coordenadas (?)

            GeneratesAptitude();
        }
        
        private void GeneratesAptitude()
        {
            for (int i = 0; i < Directions.Count; i++)
            {
                switch (Directions[i])
                {
                    case "North":
                        Aptitude += surpassedBounds("North", i);
                        break;
                    case "South":
                        Aptitude += surpassedBounds("South", i);
                        break;
                    case "West":
                        Aptitude += surpassedBounds("West", i);
                        break;
                    case "East":
                        Aptitude += surpassedBounds("East", i);
                        break;
                }
            }
        }

        private int surpassedBounds(string destiny, int nodo)
        {
            //pegar a coordenada atual, verificar no quadrante (ver com julio)

            switch (destiny)
            {
                case "North":
                    return 0;
                case "South":
                    return 0;
                case "West":
                    return 0;
                case "East":
                    return 0;
            }

            return 0;
        }

    }
}
