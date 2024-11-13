﻿using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Features.Level.Config;
using UnityEngine;

namespace Code.Gameplay.Features.Stalls.Factory
{
    public class StallsFactory : IStallsFactory
    {
        public GameEntity CreateStall(StallsSpawnData spawnData, Transform parent)
        {
            return CreateEntity
                .Empty()
                .AddStallIndex(spawnData.Index)
                .AddStallBounds(spawnData.Bounds)
                .AddWorldPosition(spawnData.SpawnPosition)
                .AddRabbitsAmount(0)
                .With(x => x.isStall = true)
                .With(x => x.isSaveRotationInSpawn = true)
                .With(x => x.isSurfaced = true)
                ;
        }
    }
}