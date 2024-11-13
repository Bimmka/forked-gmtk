using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class RemoveSunkenMarkWhenSurfacedIslandSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _islands;
        private readonly List<GameEntity> _buffer = new List<GameEntity>(8);

        public RemoveSunkenMarkWhenSurfacedIslandSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Sunken,
                    GameMatcher.WaitingSurfaceIsland,
                    GameMatcher.Surfaced)
                .NoneOf(GameMatcher.JustSunken));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands.GetEntities(_buffer))
            {
                island.isSunken = false;
                island.isWaitingSurfaceIsland = false;
            }
        }
    }
}