using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.LevelTasks.Systems
{
    public class DecreaseLevelTaskHoldDurationTimeSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _tasks;

        public DecreaseLevelTaskHoldDurationTimeSystem(GameContext game, ITimeService time)
        {
            _time = time;
            _tasks = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.LevelTask,
                    GameMatcher.LevelTaskWithHoldDuration,
                    GameMatcher.AmountConditionUncompleted,
                    GameMatcher.LevelTaskTargetHoldDurationTimeHasProgress,
                    GameMatcher.LevelTaskTargetHoldDurationTime,
                    GameMatcher.DecreaseHoldTimeProgressSpeed));
        }

        public void Execute()
        {
            foreach (GameEntity task in _tasks)
            {
                task.ReplaceLevelTaskTargetHoldDurationTime(task.LevelTaskTargetHoldDurationTime - _time.DeltaTime * task.DecreaseHoldTimeProgressSpeed);
            }
        }
    }
}