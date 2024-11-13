﻿using System.Collections.Generic;
using Code.Gameplay.Features.CharacterStats;
using Code.Gameplay.Features.CharacterStats.Indexing;
using Code.Gameplay.Features.Rabbits.Config.Rabbits;
using Code.Gameplay.Features.Rabbits.Indexing;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Statuses.Indexing;
using Entitas;

namespace Code.Common.EntityIndices
{
    public static class ContextIndicesExtensions
    {
        public static HashSet<GameEntity> ReplicationTargets(this GameContext context, int stallIndex)
        {
            return ((EntityIndex<GameEntity, ReplicationTargetKey>) context.GetEntityIndex(GameEntityIndices.ReplicationTarget))
                .GetEntities(new ReplicationTargetKey(stallIndex));
        }
        
        public static HashSet<GameEntity> TargetStatChanges(this GameContext context, Stats stat, int targetId)
        {
            return ((EntityIndex<GameEntity, StatKey>) context.GetEntityIndex(GameEntityIndices.StatChanges))
                .GetEntities(new StatKey(targetId, stat));
        }
        
        public static HashSet<GameEntity> TargetStatusesOfType(this GameContext context, StatusTypeId statusTypeId, int targetId)
        {
            return ((EntityIndex<GameEntity, StatusKey>) context.GetEntityIndex(GameEntityIndices.StatusesOfType))
                .GetEntities(new StatusKey(targetId, statusTypeId));
        }
        
        public static HashSet<GameEntity> RabbitsForHunt(this GameContext context, int stallParentIndex)
        {
            return ((EntityIndex<GameEntity, int>) context.GetEntityIndex(GameEntityIndices.RabbitsForHunt))
                .GetEntities(stallParentIndex);
        }
        
        public static HashSet<GameEntity> RabbitsByColor(this GameContext context, RabbitColorType colorType)
        {
            return ((EntityIndex<GameEntity, RabbitColorType>) context.GetEntityIndex(GameEntityIndices.RabbitsByColor))
                .GetEntities(colorType);
        }
        
        public static HashSet<GameEntity> EverythingInStall(this GameContext context,  int stallParentIndex)
        {
            return ((EntityIndex<GameEntity, int>) context.GetEntityIndex(GameEntityIndices.EverythingInStall))
                .GetEntities(stallParentIndex);
        }
    }
}