using System;

namespace EmpilhadeiraAutoguiada
{
    class Program
    {
        static void Main(string[] args)
        {
            int populationSize = 1000;
            bool elitism = true;
            //Console.WriteLine("Taxa de Mutação: ");
            //geneticAlgorithm.MutationRate = int.Parse(Console.ReadLine());
            //Console.WriteLine("Taxa de Crossover: ");            
            //geneticAlgorithm.CrossoverRate = int.Parse(Console.ReadLine());

            //var population = new Population(populationSize, new Optimizer());
            

            while (true)
            {

                //population = new Population();
                var labyrinth = Utils.GenerateLabyrinth();
                Utils.printLabyrinth(labyrinth);
                
                break;
            }
        }
    }
}
