using Code.Gameplay.Features.Stalls.Services;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class MarkSurfacedIslandSystem : IExecuteSystem
    {
        private readonly IStallService _stallService;
        private readonly IGroup<GameEntity> _islands;

        public MarkSurfacedIslandSystem(GameContext game, IStallService stallService)
        {
            _stallService = stallService;
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Sunken,
                    GameMatcher.WaitingSurfaceIsland,
                    GameMatcher.ToSurfaceTimeLeft,
                    GameMatcher.IslandStalls));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                if (island.ToSurfaceTimeLeft <= 0)
                {
                    island.isSurfaced = true;

                    foreach (int stallIndex in island.IslandStalls)
                    {
                        GameEntity stall = _stallService.GetStallEntityByIndex(stallIndex);
                        
                        if (stall == null)
                            continue;

                        stall.isSunken = false;
                        stall.isSurfaced = true;
                    }
                }
            }
        }
    }
}