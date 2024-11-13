using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Rabbits.SubFeatures.Visuals.Systems
{
    public class ApplyRabbitSociopathVisualSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _rabbits;
        private readonly List<GameEntity> _buffer = new List<GameEntity>(128);

        public ApplyRabbitSociopathVisualSystem(GameContext game)
        {
            _rabbits = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Rabbit,
                    GameMatcher.Sociopath,
                    GameMatcher.RabbitVisualChanger)
                .NoneOf(GameMatcher.SociopathVisualApplied));
        }

        public void Execute()
        {
            foreach (GameEntity rabbit in _rabbits.GetEntities(_buffer))
            {
                rabbit.RabbitVisualChanger.SetSociopath();
                rabbit.isSociopathVisualApplied = true;
            }
        }
    }
}