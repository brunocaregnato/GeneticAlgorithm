using System.Collections.Generic;

namespace EmpilhadeiraAutoguiada.Webapi.ViewModels
{
    public class GenerationsViewModel
    {
        public int GenerationsExecuted { get; set; }
        public bool ReachedMaxGenerations { get; set; }
        public IEnumerable<CoordinateViewModel> BestPath { get; set; }
        public int BestPathFitness { get; set; }
        public int FitnessImprovementFromLastIteration { get; set; }
        public int BestPathStreak { get; set; }
    }
}