using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class UpdateDelayBeforeDiveSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _islands;

        public UpdateDelayBeforeDiveSystem(GameContext game, ITimeService time)
        {
            _time = time;
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Surfaced,
                    GameMatcher.WaitingDiveIsland,
                    GameMatcher.DelayBeforeDiveLeft));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                island.ReplaceDelayBeforeDiveLeft(island.DelayBeforeDiveLeft - _time.DeltaTime);
            }
        }
    }
}