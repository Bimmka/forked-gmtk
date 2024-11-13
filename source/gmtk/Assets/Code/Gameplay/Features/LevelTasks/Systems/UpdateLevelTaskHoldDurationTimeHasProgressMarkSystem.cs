using Entitas;

namespace Code.Gameplay.Features.LevelTasks.Systems
{
    public class UpdateLevelTaskHoldDurationTimeHasProgressMarkSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _tasks;

        public UpdateLevelTaskHoldDurationTimeHasProgressMarkSystem(GameContext game)
        {
            _tasks = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.LevelTask,
                    GameMatcher.LevelTaskWithHoldDuration,
                    GameMatcher.LevelTaskTargetHoldDurationTime));
        }

        public void Execute()
        {
            foreach (GameEntity task in _tasks)
            {
                task.isLevelTaskTargetHoldDurationTimeHasProgress = task.LevelTaskTargetHoldDurationTime > 0;
                task.isLevelTaskTargetHoldDurationTimeNoProgress = task.isLevelTaskTargetHoldDurationTimeHasProgress == false;
            }
        }
    }
}