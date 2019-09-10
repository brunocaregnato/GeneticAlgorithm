using System;

namespace EmpilhadeiraAutoguiada
{
    class Program
    {
        static void Main(string[] args)
        {
            var geneticAlgorithm = new GeneticAlgorithm();
            geneticAlgorithm.MutationRate = 0.5f;
            geneticAlgorithm.CrossoverRate = 0.2f;
            geneticAlgorithm.genesNumbers = 200;
            int populationSize = 1000;
            //Console.WriteLine("Taxa de Mutação: ");
            //geneticAlgorithm.MutationRate = int.Parse(Console.ReadLine());
            //Console.WriteLine("Taxa de Crossover: ");            
            //geneticAlgorithm.CrossoverRate = int.Parse(Console.ReadLine());

            while (true)
            {
                var population = new Population(geneticAlgorithm.genesNumbers, populationSize);

                var labyrinth = Utils.GenerateLabyrinth();
                Utils.printLabyrinth(labyrinth);
                
                break;
            }
        }
    }
}
