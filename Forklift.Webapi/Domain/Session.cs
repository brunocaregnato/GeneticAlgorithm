using System;
using System.Collections.Generic;
using System.Linq;
using Forklift;
using Forklift.Webapi.ViewModels;

namespace Forklift.Webapi.Domain
{
    public class Session
    {
        public Guid Id { get; private set; }
        public bool IsActive { get; private set; }

        private Population _population;
        private int _maxGenerations;
        private int _bestRouteFitness;
        private int _fitnessImprovement;
        private int _bestRouteStreak;

        public Session(
            int populationSize,
            int maxGenerations,
            bool useElitism,
            double crossoverRate,
            double mutationRate,
            int moveNorthReward,
            int moveSouthReward,
            int moveEastReward,
            int moveWestReward,
            int completedLabirynthReward,
            int crossedWallPenalty,
            int undoMovementPenalty,
            int outOfBoundsPenalty)
        {
            Id = Guid.NewGuid();
            IsActive = true;

            _maxGenerations = maxGenerations;
            _bestRouteFitness = -27000000;
            _fitnessImprovement = -27000000;
            _bestRouteFitness = 0;

            var optimizer = new Optimizer(
                moveNorthReward,
                moveSouthReward,
                moveEastReward,
                moveWestReward,
                completedLabirynthReward,
                crossedWallPenalty,
                undoMovementPenalty,
                outOfBoundsPenalty);

            _population = new Population(
                populationSize,
                optimizer,
                Utils.GenerateLabyrinth(),
                useElitism,
                crossoverRate,
                mutationRate);
        }

        public GenerationsViewModel AdvanceGenerations(int count)
        {
            if (!IsActive)
                throw new InvalidOperationException();

            for (var i = 0; i < count; i++)
            {
                _population.AdvanceGeneration();

                if (_population.BestRouteFitness > _bestRouteFitness)
                {
                    _fitnessImprovement = _population.BestRouteFitness - _fitnessImprovement;
                    _bestRouteFitness = _population.BestRouteFitness;
                    _bestRouteStreak = 0;
                }

                _bestRouteStreak++;

                if (_population.CurrentGeneration == _maxGenerations)
                {
                    count = i + 1;
                    IsActive = false;
                    break;
                }
            }

            return new GenerationsViewModel
            {
                GenerationsExecuted = count,
                ReachedMaxGenerations = _population.CurrentGeneration == _maxGenerations,
                BestPath = GetBestPath(),
                BestPathFitness = _population.BestRouteFitness,
                FitnessImprovementFromLastIteration = _fitnessImprovement,
                BestPathStreak = _bestRouteStreak
            };
        }

        private IEnumerable<CoordinateViewModel> GetBestPath()
        {
            var x = 0;
            var y = 8;
            var res = new List<CoordinateViewModel>();
            
            foreach (var movement in _population.BestRoute.Movements)
            {
                res.Add(new CoordinateViewModel(x, y));

                switch (movement)
                {
                    case Route.Movement.North:
                        y--;
                        break;
                    
                    case Route.Movement.South:
                        y++;
                        break;
                    
                    case Route.Movement.East:
                        x++;
                        break;
                    
                    case Route.Movement.West:
                        x--;
                        break;
                }
            }

            res.Add(new CoordinateViewModel(x, y));
            return res;
        }
    }
}