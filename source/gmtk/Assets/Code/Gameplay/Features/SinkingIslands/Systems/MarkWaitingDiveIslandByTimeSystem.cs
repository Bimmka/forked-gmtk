using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class MarkWaitingDiveIslandByTimeSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _islands;

        public MarkWaitingDiveIslandByTimeSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.SinkingByTimeIsland,
                    GameMatcher.Surfaced,
                    GameMatcher.NextDiveTimeLeft));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                if (island.NextDiveTimeLeft <= 0)
                    island.isWaitingDiveIsland = true;
            }
        }
    }
}