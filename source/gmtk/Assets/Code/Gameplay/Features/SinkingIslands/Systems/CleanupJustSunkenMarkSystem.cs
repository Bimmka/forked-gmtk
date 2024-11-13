using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class CleanupJustSunkenMarkSystem : ICleanupSystem
    {
        private readonly IGroup<GameEntity> _islands;
        private readonly List<GameEntity> _buffer = new(8);

        public CleanupJustSunkenMarkSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(GameMatcher.JustSunken));
        }

        public void Cleanup()
        {
            foreach (GameEntity island in _islands.GetEntities(_buffer))
            {
                island.isJustSunken = false;
            }
        }
    }
}