using Code.Gameplay.Features.Rabbits.SubFeatures.Visuals.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.Rabbits.SubFeatures.Visuals
{
    public sealed class RabbitVisualsFeature : Feature
    {
        public RabbitVisualsFeature(ISystemFactory systems)
        {
            Add(systems.Create<ApplyRabbitSociopathVisualSystem>());
        }
    }
}