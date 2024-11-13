using Code.Common.EntityIndices;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class MarkSunkenEverythingOnIslandSystem : IExecuteSystem
    {
        private readonly GameContext _game;
        private readonly IGroup<GameEntity> _islands;

        public MarkSunkenEverythingOnIslandSystem(GameContext game)
        {
            _game = game;
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.JustSunken,
                    GameMatcher.IslandStalls));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                foreach (int stallIndex in island.IslandStalls)
                {
                    var elementsInStall = _game.EverythingInStall(stallIndex);

                    foreach (GameEntity element in elementsInStall)
                    {
                        element.isSunken = true;
                    }
                }
            }
        }
    }
}