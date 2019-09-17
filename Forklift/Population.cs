using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forklift
{
    public class Population
    {
        private List<Route> _routes;
        private Optimizer _optimizer;
        private Quadrant[,] _map;

        public int PopulationSize { get; set; }
        public int CurrentGeneration { get; private set; }
        public Route BestRoute { get; private set; }
        public int BestRouteFitness { get; private set; }
        public bool Elitism { get; private set; }
        public double CrossoverRate { get; private set; }
        public double MutationRate { get; private set; }

        public Population(int populationSize, Optimizer optimizer, Quadrant[,] map, bool elitism, double crossoverRate, double mutationRate)
        {
            CurrentGeneration = 0;
            PopulationSize = populationSize;
            _optimizer = optimizer;
            _map = map;
            Elitism = elitism;
            CrossoverRate = crossoverRate;
            MutationRate = mutationRate;

            _routes = new List<Route>();
            
            for (int i = 0;  i < populationSize; i++)
            {
                var movements = new List<Route.Movement>();
                for (int j = 0; j < 27; j++)
                {
                    var r = new Random();
                    movements.Add((Route.Movement)r.Next(0, 3));
                }
                var route = new Route(movements);
                _routes.Add(route);
            }

            AdvanceGeneration();
        }

        public void AdvanceGeneration()
        {
            var r = new Random();
            var nextGeneration = new List<Route>();
            var iterationSize = PopulationSize / 2;

            if (Elitism)
            {
                nextGeneration.AddRange(GetElite(2));
                iterationSize--;
            }

            foreach(var iteration in Enumerable.Range(0, iterationSize))
            {
                var routes = new[]
                {
                    RandomTournament(r),
                    RandomTournament(r)
                }.AsEnumerable();

                if (r.Next() % 100 < CrossoverRate)
                    routes = GetCrossover(routes.First(), routes.Last(), r);

                if (r.Next() % 100 < MutationRate)
                    routes = Mutate(routes);

                nextGeneration.AddRange(routes);
            }

            _routes = nextGeneration.OrderByDescending(route => _optimizer.GetFitness(route, _map)).ToList();
            CurrentGeneration++;
            BestRoute = _routes.First();
            BestRouteFitness = _optimizer.GetFitness(BestRoute, _map);
        }

        private Route RandomTournament(Random r)
        {
            var entrants = new List<Route>();

            for (int i = 0; i < 4; i++)
            {
                var t = r.Next();
                entrants.Add(_routes[t % PopulationSize]);
            }

            //foreach (var it in Enumerable.Range(0, 5))


            return entrants.OrderBy(route => _optimizer.GetFitness(route, _map)).Last();
        }

        private IEnumerable<Route> GetElite(int quantity)
            => _routes.OrderByDescending(route => _optimizer.GetFitness(route, _map)).Take(quantity).Select(route => new Route(route.Movements));

        private IEnumerable<Route> GetCrossover(Route mother, Route father, Random random)
        {
            var crossoverPoint = random.Next() % 27;
            var child1 = new Route(mother.Movements.Take(crossoverPoint).Concat(father.Movements.Skip(crossoverPoint).Take(27 - crossoverPoint)));
            var child2 = new Route(father.Movements.Take(crossoverPoint).Concat(mother.Movements.Skip(crossoverPoint).Take(27 - crossoverPoint)));
            return new[] { child1, child2 };
        }

        private IEnumerable<Route> Mutate(IEnumerable<Route> routes)
        {
            var newRoutes = new List<Route>();
            var r = new Random();
            
            foreach (var route in routes)
            {
                var posAleatoria = r.Next(0, 26);
                var movements = route.Movements.ToArray();
                var t = (Route.Movement)(r.Next() % 4);
                movements[posAleatoria] = t;

                newRoutes.Add(new Route(movements));
            }

            return newRoutes;
        }
    }
}
