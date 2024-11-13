using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class RemoveSurfacedMarkWhenSinkingIslandSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _islands;
        private readonly List<GameEntity> _buffer = new List<GameEntity>(8);

        public RemoveSurfacedMarkWhenSinkingIslandSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Surfaced,
                    GameMatcher.WaitingDiveIsland,
                    GameMatcher.JustSunken));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands.GetEntities(_buffer))
            {
                island.isSurfaced = false;
                island.isWaitingDiveIsland = false;
            }
        }
    }
}