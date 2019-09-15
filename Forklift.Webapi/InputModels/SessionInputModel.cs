using Forklift.Webapi.Domain;

namespace Forklift.Webapi.InputModels
{
    public class SessionInputModel
    {
        public int PopulationSize { get; set; }
        public int MaxGenerations { get; set; }
        public bool UseElitism { get; set; }
        public double CrossoverRate { get; set; }
        public double MutationRate { get; set; }
        public int MoveNorthReward { get; set; }
        public int MoveSouthReward { get; set; }
        public int MoveEastReward { get; set; }
        public int MoveWestReward { get; set; }
        public int CompletedLabirynthReward { get; set; }
        public int CrossedWallPenalty { get; set; }
        public int UndoMovementPenalty { get; set; }
        public int OutOfBoundsPenalty { get; set; }

        public static implicit operator Session(SessionInputModel inputModel)
        {
            if (inputModel == null)
                return null;

            return new Session(
                inputModel.PopulationSize,
                inputModel.MaxGenerations,
                inputModel.UseElitism,
                inputModel.CrossoverRate,
                inputModel.MutationRate,
                inputModel.MoveNorthReward,
                inputModel.MoveSouthReward,
                inputModel.MoveEastReward,
                inputModel.MoveWestReward,
                inputModel.CompletedLabirynthReward,
                inputModel.CrossedWallPenalty,
                inputModel.UndoMovementPenalty,
                inputModel.OutOfBoundsPenalty);
        }
    }
}