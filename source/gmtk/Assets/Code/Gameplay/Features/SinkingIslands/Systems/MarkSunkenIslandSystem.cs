using Code.Gameplay.Features.Stalls.Services;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class MarkSunkenIslandSystem : IExecuteSystem
    {
        private readonly IStallService _stallService;
        private readonly IGroup<GameEntity> _islands;

        public MarkSunkenIslandSystem(GameContext game, IStallService stallService)
        {
            _stallService = stallService;
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Surfaced,
                    GameMatcher.WaitingDiveIsland,
                    GameMatcher.DelayBeforeDiveLeft,
                    GameMatcher.IslandStalls));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                if (island.DelayBeforeDiveLeft <= 0)
                {
                    island.isSunken = true;
                    island.isJustSunken = true;
                    island.isWaitingSurfaceIsland = true;

                    foreach (int stallIndex in island.IslandStalls)
                    {
                        GameEntity stall = _stallService.GetStallEntityByIndex(stallIndex);
                        
                        if (stall == null)
                            continue;

                        stall.isSunken = true;
                        stall.isSurfaced = false;
                    }
                }
            }
        }
    }
}