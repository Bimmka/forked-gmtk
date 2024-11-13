using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class RefreshTimeToSurfaceSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _islands;

        public RefreshTimeToSurfaceSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Surfaced,
                    GameMatcher.Sunken,
                    GameMatcher.WaitingSurfaceIsland,
                    GameMatcher.ToSurfaceTime,
                    GameMatcher.ToSurfaceTimeLeft));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                island.ReplaceToSurfaceTimeLeft(island.ToSurfaceTime);
            }
        }
    }
}