using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Death.Systems
{
    public class MarkDeadWhenSunkenSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _sunken;
        private readonly List<GameEntity> _buffer = new List<GameEntity>(32);

        public MarkDeadWhenSunkenSystem(GameContext game)
        {
            _sunken = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Sunken,
                    GameMatcher.Alive));
        }

        public void Execute()
        {
            foreach (GameEntity eaten in _sunken.GetEntities(_buffer))
            {
                eaten.isDead = true;
                eaten.isAlive = false;
            }
        }
    }
}