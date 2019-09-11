using System;
using System.Collections.Generic;
using System.Text;

namespace EmpilhadeiraAutoguiada
{
    class GeneticAlgorithm
    {
        public double MutationRate { get; set; }
        public double CrossoverRate { get; set; }
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

        public Population NewGeneration(Population population, bool elitism)
        {
            var random = new Random();
            //nova população do mesmo tamanho da antiga
            var newPopulation = new Population(population.PopulationSize);

            //se tiver elitismo, mantém o melhor indivíduo da geração atual
            if (elitism)
            {
                newPopulation.Forklift[0] = population.Forklift[0];
            }

            //insere novos indivíduos na nova população, até atingir o tamanho máximo
            while (newPopulation.GetNumbersOfForklifts() < newPopulation.PopulationSize)
            {
                //seleciona os 2 pais por torneio
                var parents = TournamentSelection(population);

                var childrens = new Forklift[2];

                //verifica a taxa de crossover, se sim realiza o crossover, se não, mantém os pais selecionados para a próxima geração
                if (random.NextDouble() <= CrossoverRate)
                {
                    childrens = Crossover(parents[1], parents[0]);
                }
                else
                {
                    childrens[0] = new Forklift(parents[0].Directions);
                    childrens[1] = new Forklift(parents[1].Directions);
                }
            
                //adiciona os filhos na nova geração
                newPopulation.SetForklift(childrens[0]);
                newPopulation.SetForklift(childrens[1]);
            }
            
            //ordena a nova população
            newPopulation.SortPopulation();
            return newPopulation;
        }

        public Forklift[] TournamentSelection(Population population)
        {
            var random = new Random();
            var intermediatePopulation = new Population(3);

            //seleciona 3 indivíduos aleatóriamente na população
            intermediatePopulation.SetForklift(population.Forklift[random.Next(population.PopulationSize)]);
            intermediatePopulation.SetForklift(population.Forklift[random.Next(population.PopulationSize)]);
            intermediatePopulation.SetForklift(population.Forklift[random.Next(population.PopulationSize)]);

            //ordena a população
            intermediatePopulation.SortPopulation();

            var parents = new Forklift[2];

            //seleciona os 2 melhores deste população
            parents[0] = intermediatePopulation.Forklift[0];
            parents[1] = intermediatePopulation.Forklift[1];

            return parents;
        }

        public Forklift[] Crossover(Forklift forklift1, Forklift forklift2)
        {
            var random = new Random();
            //sorteia o ponto de corte
            int cutoff1 = random.Next((forklift1.Directions.Count/2) - 2) + 1;
            int cutoff2 = random.Next((forklift1.Directions.Count/2) - 2) + forklift1.Directions.Count/2;

            var childrens = new Forklift[2];

            //pega os genes dos pais
            List<string> parentGene1 = forklift1.Directions;
            List<string> parentGene2 = forklift2.Directions;

            List<string> childrenGene1 = new List<string>();
            List<string> childrenGene2 = new List<string>();

            //realiza o corte do Gene 1 
            for (int nodo = 0; nodo < cutoff1; nodo++)
            {
                childrenGene1.Add(childrenGene1[nodo]);
            }
            for (int nodo = cutoff1; nodo < cutoff2; nodo++)
            {
                childrenGene1.Add(parentGene2[nodo]);
            }
            for (int nodo = cutoff2; nodo < parentGene1.Count; nodo++)
            {
                childrenGene1.Add(parentGene1[0]);
            }

            //realiza o corte do Gene 2 
            for (int nodo = 0; nodo < cutoff1; nodo++)
            {
                childrenGene2.Add(parentGene2[nodo]);
            }
            for (int nodo = cutoff1; nodo < cutoff2; nodo++)
            {
                childrenGene2.Add(parentGene1[nodo]);
            }
            for (int nodo = cutoff2; nodo < parentGene1.Count; nodo++)
            {
                childrenGene2.Add(parentGene2[0]);
            }
            //cria o novo indivíduo com os genes dos pais
            childrens[0] = new Forklift(childrenGene1);
            childrens[1] = new Forklift(childrenGene2);

            return childrens;
        }
    }
}
