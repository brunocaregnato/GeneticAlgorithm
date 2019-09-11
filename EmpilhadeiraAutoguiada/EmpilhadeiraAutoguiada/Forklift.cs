using System;
using System.Collections.Generic;
using System.Text;

namespace EmpilhadeiraAutoguiada
{
    class Forklift
    {
        public GeneticAlgorithm GeneticAlgorithm { get; set; }
        public List<string> Directions { get; set; } = new List<string>();
        public int Aptitude { get; set; }

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
                        Aptitude += SurpassedBounds("North", i);
                        break;
                    case "South":
                        Aptitude += SurpassedBounds("South", i);
                        break;
                    case "West":
                        Aptitude += SurpassedBounds("West", i);
                        break;
                    case "East":
                        Aptitude += SurpassedBounds("East", i);
                        break;
                }
            }
        }

        private int SurpassedBounds(string destiny, int nodo)
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

        //cria um indivíduo com os genes definidos
        public Forklift(List<string> direction)
        {
            var random = new Random();
            GeneticAlgorithm = new GeneticAlgorithm();

            var possibilities = GeneticAlgorithm.Possibilities;
            var directionAux = new List<string>();
            Directions = direction;
            //se for mutar, cria um gene aleatório
            if (random.NextDouble() <= GeneticAlgorithm.MutationRate)
            {

                int posAleatoria = random.Next(Directions.Count);
                for (int i = 0; i < Directions.Count; i++)
                {
                    if (i == posAleatoria)
                    {
                        directionAux.Add(possibilities[random.Next(4)]);
                    }
                    else
                    {
                        directionAux.Add(Directions[i]);
                    }
                }
                Directions = directionAux;
            }
            //posicao = new Coordenadas(0, 9);

            GeneratesAptitude();
        }

    }
}
