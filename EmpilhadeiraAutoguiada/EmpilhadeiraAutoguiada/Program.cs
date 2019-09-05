using System;

namespace EmpilhadeiraAutoguiada
{
    class Program
    {
        static void Main(string[] args)
        {
            var geneticAlgorithm = new GeneticAlgorithm();

            //Console.WriteLine("Taxa de Mutação: ");
            //geneticAlgorithm.MutationRate = int.Parse(Console.ReadLine());
            //Console.WriteLine("Taxa de Crossover: ");
            //geneticAlgorithm.CrossoverRate = int.Parse(Console.ReadLine());
            while (true)
            {
                var labyrinth = Utils.GenerateLabyrinth();
                Utils.printLabyrinth(labyrinth);
                
                //string path = geneticAlgorithm.startLabyrinth(labyrinth);
                break;

            }
        }

        /* Método para criação do labirinto */
        


    }
}
