﻿using Code.Gameplay.Features.CharacterStats;
using Code.Gameplay.Features.CharacterStats.Indexing;
using Code.Gameplay.Features.Rabbits;
using Code.Gameplay.Features.Rabbits.Config.Rabbits;
using Code.Gameplay.Features.Rabbits.Indexing;
using Code.Gameplay.Features.Statuses;
using Code.Gameplay.Features.Statuses.Indexing;
using Entitas;
using Zenject;

namespace Code.Common.EntityIndices
{
  public class GameEntityIndices : IInitializable
  {
    private readonly GameContext _game;

    public const string ReplicationTarget = "ReplicationTarget";
    public const string StatChanges = "StatChanges";
    public const string StatusesOfType = "StatusesOfType";
    public const string RabbitsForHunt = "RabbitsForHunt";
    public const string RabbitsByColor = "RabbitByColor";
    public const string EverythingInStall = "EverythingInStall";

    public GameEntityIndices(GameContext game)
    {
      _game = game;
    }

    public void Initialize()
    {
      _game.AddEntityIndex(new EntityIndex<GameEntity, ReplicationTargetKey>(
        name: ReplicationTarget,
        _game.GetGroup(GameMatcher.AllOf(
          GameMatcher.Rabbit,
          GameMatcher.CanBeChosenForReplication,
          GameMatcher.StallParentIndex,
          GameMatcher.RabbitColorType,
          GameMatcher.Id,
          GameMatcher.ReplicationAvailable)),
        getKey: GetReplicationTargetKey,
        new ReplicationTargetKeyEqualityComparer()));
      
      _game.AddEntityIndex(new EntityIndex<GameEntity, StatKey>(
        name: StatChanges,
        _game.GetGroup(GameMatcher.AllOf(
          GameMatcher.StatChange,
          GameMatcher.TargetId)),
        getKey: GetTargetStatKey,
        new StatKeyEqualityComparer()));
      
      _game.AddEntityIndex(new EntityIndex<GameEntity, StatusKey>(
        name: StatusesOfType,
        _game.GetGroup(GameMatcher.AllOf(
          GameMatcher.StatusTypeId,
          GameMatcher.TargetId,
          GameMatcher.Status,
          GameMatcher.Duration,
          GameMatcher.TimeLeft)),
        getKey: GetTargetStatusKey,
        new StatusKeyEqualityComparer()));
      
      _game.AddEntityIndex(new EntityIndex<GameEntity, int>(
        name: RabbitsForHunt,
        _game.GetGroup(
          GameMatcher.AllOf(
          GameMatcher.Rabbit,
          GameMatcher.Id,
          GameMatcher.Alive,
          GameMatcher.StallParentIndex,
          GameMatcher.InDanger)
          .NoneOf(
            GameMatcher.Replicating,
            GameMatcher.Dragging)),
        getKey: (entity, component) => (component as StallParentIndex)?.Value ?? entity.StallParentIndex));
      
      _game.AddEntityIndex(new EntityIndex<GameEntity, RabbitColorType>(
        name: RabbitsByColor,
        _game.GetGroup(
          GameMatcher.AllOf(
              GameMatcher.Rabbit,
              GameMatcher.Id,
              GameMatcher.Alive,
              GameMatcher.RabbitColorType)),
        getKey: (entity, component) => (component as RabbitColorTypeComponent)?.Value ?? entity.RabbitColorType));
      
      _game.AddEntityIndex(new EntityIndex<GameEntity, int>(
        name: EverythingInStall,
        _game.GetGroup(
          GameMatcher.AllOf(
              GameMatcher.Id,
              GameMatcher.StallParentIndex,
              GameMatcher.StayOnIsland)
            .NoneOf(
              GameMatcher.Dead)),
        getKey: (entity, component) => (component as StallParentIndex)?.Value ?? entity.StallParentIndex));
    }
    
    private ReplicationTargetKey GetReplicationTargetKey(GameEntity entity, IComponent component)
    {
      return new ReplicationTargetKey(
        (component as StallParentIndex)?.Value ?? entity.StallParentIndex);
    }
    
    private StatKey GetTargetStatKey(GameEntity entity, IComponent component)
    {
      return new StatKey(
        (component as TargetId)?.Value ?? entity.TargetId,
        (component as StatChange)?.Value ?? entity.StatChange);
    }
    
    private StatusKey GetTargetStatusKey(GameEntity entity, IComponent component)
    {
      return new StatusKey(
        (component as TargetId)?.Value ?? entity.TargetId,
        (component as StatusTypeIdComponent)?.Value ?? entity.StatusTypeId);
    }
  }
}