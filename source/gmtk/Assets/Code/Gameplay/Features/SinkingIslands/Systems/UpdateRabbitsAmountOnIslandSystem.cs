using Code.Gameplay.Features.Stalls.Services;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class UpdateRabbitsAmountOnIslandSystem : IExecuteSystem
    {
        private readonly IStallService _stallService;
        private readonly IGroup<GameEntity> _islands;

        public UpdateRabbitsAmountOnIslandSystem(GameContext game, IStallService stallService)
        {
            _stallService = stallService;
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.SinkingByWeightIsland,
                    GameMatcher.IslandStalls,
                    GameMatcher.CurrentRabbitsAmountBeforeDive,
                    GameMatcher.Surfaced)
                .NoneOf(GameMatcher.WaitingDiveIsland));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                int totalRabbitAmount = 0;
                
                foreach (int islandStallIndex in island.IslandStalls)
                {
                    var stallEntity = _stallService.GetStallEntityByIndex(islandStallIndex);
                    
                    if (stallEntity == null || stallEntity.hasRabbitsAmount == false)
                        continue;

                    totalRabbitAmount += stallEntity.RabbitsAmount;
                }

                island.ReplaceCurrentRabbitsAmountBeforeDive(totalRabbitAmount);
            }
        }
    }
}