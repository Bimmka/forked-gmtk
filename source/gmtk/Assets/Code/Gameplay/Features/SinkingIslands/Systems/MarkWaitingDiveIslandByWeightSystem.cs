using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class MarkWaitingDiveIslandByWeightSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _islands;

        public MarkWaitingDiveIslandByWeightSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.SinkingByWeightIsland,
                    GameMatcher.Surfaced,
                    GameMatcher.MaxRabbitsAmountBeforeDive,
                    GameMatcher.CurrentRabbitsAmountBeforeDive));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                if (island.CurrentRabbitsAmountBeforeDive >= island.MaxRabbitsAmountBeforeDive)
                    island.isWaitingDiveIsland = true;
            }
        }
    }
}