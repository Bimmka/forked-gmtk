using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class UpdateTimeBeforeDiveSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _islands;

        public UpdateTimeBeforeDiveSystem(GameContext game, ITimeService time)
        {
            _time = time;
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.SinkingByTimeIsland,
                    GameMatcher.Surfaced,
                    GameMatcher.NextDiveTimeLeft)
                .NoneOf(GameMatcher.WaitingDiveIsland));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                island.ReplaceNextDiveTimeLeft(island.NextDiveTimeLeft - _time.DeltaTime);
            }
        }
    }
}