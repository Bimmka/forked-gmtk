using Entitas;

namespace Code.Gameplay.Features.SinkingIslands.Systems
{
    public class RefreshRabbitsOnIslandsSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _islands;

        public RefreshRabbitsOnIslandsSystem(GameContext game)
        {
            _islands = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.SinkingByWeightIsland,
                    GameMatcher.CurrentRabbitsAmountBeforeDive,
                    GameMatcher.Sunken));
        }

        public void Execute()
        {
            foreach (GameEntity island in _islands)
            {
                island.ReplaceCurrentRabbitsAmountBeforeDive(0);
            }
        }
    }
}