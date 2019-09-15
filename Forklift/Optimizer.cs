using System;
using System.Collections.Generic;
using System.Text;

namespace Forklift
{
    public class Optimizer
    {
        public int MoveNorthReward { get; private set; }
        public int MoveSouthReward { get; private set; }
        public int MoveEastReward { get; private set; }
        public int MoveWestReward { get; private set; }
        public int CompletedLabirynthReward { get; private set; }
        public int CrossedWallPenalty { get; private set; }
        public int UndoMovementPenalty { get; private set; }
        public int OutOfBoundsPenalty { get; private set; }

        public Optimizer(int moveNorthReward, int moveSouthReward, int moveEastReward, int moveWestReward, int completedLabirynthReward, int crossedWallPenalty, int undoMovementPenalty, int outOfBoundsPenalty)
        {
            MoveNorthReward = moveNorthReward;
            MoveSouthReward = moveSouthReward;
            MoveEastReward = moveEastReward;
            MoveWestReward = moveWestReward;
            CompletedLabirynthReward = completedLabirynthReward;
            CrossedWallPenalty = crossedWallPenalty;
            UndoMovementPenalty = undoMovementPenalty;
            OutOfBoundsPenalty = outOfBoundsPenalty;
        }

        public int GetFitness(Route route, Quadrant[,] map)
        {
            var mapWidth = map.GetLength(0);
            var mapHeight = map.GetLength(1);
            var fitness = 0;

            var lastMovement = default(Route.Movement?);
            var x = 0;
            var y = mapHeight - 1;

            foreach (var movement in route.Movements)
            {
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

                if (x < 0 || x >= mapWidth || y < 0 || y >= mapHeight)
                {
                    fitness -= OutOfBoundsPenalty;
                    continue;
                }

                switch (movement)
                {
                    case Route.Movement.North:
                        if (map[x, y].SouthWall)
                            fitness -= CrossedWallPenalty;
                        else
                            fitness += MoveNorthReward;

                        break;

                    case Route.Movement.South:
                        if (map[x, y].NorthWall)
                            fitness -= CrossedWallPenalty;
                        else
                            fitness += MoveSouthReward;

                        break;

                    case Route.Movement.East:
                        if (x == 10 && y == 0)
                        {
                            fitness += CompletedLabirynthReward;
                            return fitness;
                        }

                        if (map[x, y].WeastWall)
                            fitness -= CrossedWallPenalty;
                        else
                            fitness += MoveEastReward;

                        break;

                    case Route.Movement.West:
                        if (map[x, y].EastWall)
                            fitness -= CrossedWallPenalty;
                        else
                            fitness += MoveWestReward;

                        break;
                }

                if (lastMovement.HasValue && (
                    (lastMovement.Value == Route.Movement.North && movement == Route.Movement.South)
                    || (lastMovement.Value == Route.Movement.South && movement == Route.Movement.North)
                    || (lastMovement.Value == Route.Movement.East && movement == Route.Movement.West)
                    || (lastMovement.Value == Route.Movement.West && movement == Route.Movement.East)))
                    fitness -= UndoMovementPenalty;

                lastMovement = movement;
            }

            return fitness;
        }
    }
}
