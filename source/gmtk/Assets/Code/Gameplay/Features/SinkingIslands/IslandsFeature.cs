using Code.Gameplay.Features.SinkingIslands.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.SinkingIslands
{
    public sealed class IslandsFeature : Feature
    {
        public IslandsFeature(ISystemFactory systems)
        {
            Add(systems.Create<UpdateTimeBeforeDiveSystem>());
            Add(systems.Create<UpdateDelayBeforeDiveSystem>());
            Add(systems.Create<UpdateTimeToSurfaceSystem>());
            Add(systems.Create<UpdateRabbitsAmountOnIslandSystem>());

            Add(systems.Create<MarkWaitingDiveIslandByTimeSystem>());
            Add(systems.Create<MarkWaitingDiveIslandByWeightSystem>());
            Add(systems.Create<RefreshTimeBeforeNextDiveSystem>());
            Add(systems.Create<MarkSunkenIslandSystem>());
            Add(systems.Create<RefreshRabbitsOnIslandsSystem>());
            Add(systems.Create<RefreshWaitingDiveTimeSystem>());
            Add(systems.Create<MarkSurfacedIslandSystem>());
            Add(systems.Create<RefreshTimeToSurfaceSystem>());
            
            Add(systems.Create<RemoveSurfacedMarkWhenSinkingIslandSystem>());
            Add(systems.Create<RemoveSunkenMarkWhenSurfacedIslandSystem>());

            Add(systems.Create<MarkSunkenEverythingOnIslandSystem>());

            Add(systems.Create<CleanupJustSunkenMarkSystem>());
        }
    }
}