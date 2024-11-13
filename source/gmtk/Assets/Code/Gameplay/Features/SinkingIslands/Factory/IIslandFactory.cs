using Code.Gameplay.Features.Level.Config;

namespace Code.Gameplay.Features.SinkingIslands.Factory
{
    public interface IIslandFactory
    {
        GameEntity CreateIsland(IslandData setup);
    }
}