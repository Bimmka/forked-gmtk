using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class RefreshTimeBeforeNextDiveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _islands;

        public RefreshTimeBeforeNextDiveSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.SinkingByTimeIsland,
                    GameMatcher.WaitingDiveIsland,
                    GameMatcher.NextDiveTime,
                    GameMatcher.NextDiveTimeLeft));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                island.ReplaceNextDiveTimeLeft(island.NextDiveTime);
            }
        }
    }
}