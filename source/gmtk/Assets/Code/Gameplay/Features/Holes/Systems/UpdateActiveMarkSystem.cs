using Entitas;

namespace Code.Gameplay.Features.Holes.Systems
{
    public class UpdateActiveMarkSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _spawners;

        public UpdateActiveMarkSystem(GameContext game)
        {
            _spawners = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.Hole));
        }

        public void Execute()
        {
            foreach (GameEntity spawner in _spawners)
            {
                spawner.isActive = spawner.isSunken == false;
            }
        }
    }
}