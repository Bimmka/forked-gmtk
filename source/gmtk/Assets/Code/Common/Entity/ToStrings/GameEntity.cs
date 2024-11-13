﻿using System;
using System.Linq;
using System.Text;
using Code.Common.Entity.ToStrings;
using Code.Common.Extensions;
using Code.Gameplay.Features.Foxes;
using Code.Gameplay.Features.Holes;
using Code.Gameplay.Features.Infections;
using Code.Gameplay.Features.LevelTasks;
using Code.Gameplay.Features.Rabbits;
using Code.Gameplay.Features.SinkingIslands;
using Code.Gameplay.Features.Statuses;
using Entitas;
using UnityEngine;

// ReSharper disable once CheckNamespace
public sealed partial class GameEntity : INamedEntity
{
  private EntityPrinter _printer;

  public override string ToString()
  {
    if (_printer == null)
      _printer = new EntityPrinter(this);

    _printer.InvalidateCache();

    return _printer.BuildToString();
  }

  public string EntityName(IComponent[] components)
  {
    try
    {
      if (components.Length == 1)
        return components[0].GetType().Name;

      foreach (IComponent component in components)
      {
        switch (component.GetType().Name)
        {
          case nameof(Rabbit):
            return PrintRabbit();
          case nameof(Code.Gameplay.Features.CharacterStats.StatChange):
            return PrintStatChange();
          case nameof(Infection):
            return PrintInfection();
          case nameof(Status):
            return PrintStatus();
          case nameof(Fox):
            return PrintFox();
          case nameof(Hole):
            return PrintHole();
          case nameof(LevelTask):
            return PrintLevelTask();
          case nameof(SinkingIsland):
            return PrintIsland();
        }
      }
    }
    catch (Exception exception)
    {
      Debug.LogError(exception.Message);
    }

    return components.First().GetType().Name;
  }

  private string PrintRabbit()
  {
    return new StringBuilder($"Rabbit ")
      .With(s => s.Append($"Id:{Id}"), when: hasId)
      .ToString();
  }
  
  private string PrintStatChange()
  {
    return new StringBuilder($"State Change ")
      .With(s => s.Append($"To:{TargetId}"), when: hasTargetId)
      .ToString();
  }
  
  private string PrintInfection()
  {
    return new StringBuilder($"Infection ")
      .With(s => s.Append($"By Level"), when: isLevelInfection)
      .With(s => s.Append($"By: {CarrierOfInfectionId}"), when: hasCarrierOfInfectionId)
      .ToString();
  }
  
  private string PrintStatus()
  {
    return new StringBuilder($"Status ")
      .With(s => s.Append($"Type {StatusTypeId}"), when: hasStatusTypeId)
      .With(s => s.Append($"To: {TargetId}"), when: hasTargetId)
      .ToString();
  }
  
  private string PrintFox()
  {
    return new StringBuilder($"Fox ")
      .With(s => s.Append($"Id: {Id}"), when: hasId)
      .ToString();
  }
  
  private string PrintHole()
  {
    return new StringBuilder($"Hole ")
      .With(s => s.Append($"Id: {Id}"), when: hasId)
      .ToString();
  }
  
  private string PrintLevelTask()
  {
    return new StringBuilder($"Level Task ")
      .With(s => s.Append($"Type: {LevelTaskType}"), when: hasLevelTaskType)
      .ToString();
  }
  
  private string PrintIsland()
  {
    return new StringBuilder($"Island Id: {Id} ")
      .With(s => s.Append($"Time Sink"), when: isSinkingByTimeIsland)
      .With(s => s.Append($"Weight Sink"), when: isSinkingByWeightIsland)
      .ToString();
  }
  
  public string BaseToString() => base.ToString();
}