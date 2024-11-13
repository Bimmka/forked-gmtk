using System.Collections.Generic;
using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Level.Config;
using Code.Gameplay.Features.SinkingIslands.Config;
using Code.Infrastructure.Identifiers;

namespace Code.Gameplay.Features.SinkingIslands.Factory
{
    public class IslandFactory : IIslandFactory
    {
        private readonly IIdentifierService _identifierService;

        public IslandFactory(IIdentifierService identifierService)
        {
            _identifierService = identifierService;
        }
        
        public GameEntity CreateIsland(IslandData setup)
        {
            GameEntity entity = CreateEntity.Empty()
                .AddId(_identifierService.Next())
                .AddIslandStalls(new List<int>(setup.StallsOnIsland))
                .AddToSurfaceTime(setup.ToSurfaceTime)
                .AddToSurfaceTimeLeft(setup.ToSurfaceTime)
                .AddDelayBeforeDive(setup.DelayBeforeDive)
                .AddDelayBeforeDiveLeft(setup.DelayBeforeDive)
                .With(x => x.isSurfaced = true)
                .With(x => x.isSinkingIsland = true);

            if (setup.DiveType == IslandDiveType.ByTime)
            {
                entity.AddNextDiveTime(setup.NextDiveTime)
                    .AddNextDiveTimeLeft(setup.NextDiveTime)
                    .With(x => x.isSinkingByTimeIsland = true);
            }
            else if (setup.DiveType == IslandDiveType.ByWeight)
            {
                entity.AddMaxRabbitsAmountBeforeDive(setup.MaxRabbitsBeforeDive)
                    .AddCurrentRabbitsAmountBeforeDive(0)
                    .With(x => x.isSinkingByWeightIsland = true);
            }

            return entity;
        }
    }
}