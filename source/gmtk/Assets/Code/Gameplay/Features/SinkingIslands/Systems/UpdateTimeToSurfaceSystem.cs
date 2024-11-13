using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class UpdateTimeToSurfaceSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _islands;

        public UpdateTimeToSurfaceSystem(GameContext game, ITimeService time)
        {
            _time = time;
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Sunken,
                    GameMatcher.WaitingSurfaceIsland,
                    GameMatcher.ToSurfaceTimeLeft));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                island.ReplaceToSurfaceTimeLeft(island.ToSurfaceTimeLeft - _time.DeltaTime);
            }
        }
    }
}