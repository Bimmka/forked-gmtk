using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class RefreshWaitingDiveTimeSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _islands;

        public RefreshWaitingDiveTimeSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.WaitingDiveIsland,
                    GameMatcher.Sunken,
                    GameMatcher.DelayBeforeDive,
                    GameMatcher.DelayBeforeDiveLeft));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                island.ReplaceDelayBeforeDiveLeft(island.DelayBeforeDive);
            }
        }
    }
}