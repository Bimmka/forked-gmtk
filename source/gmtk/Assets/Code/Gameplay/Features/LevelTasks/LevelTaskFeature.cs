﻿using Code.Gameplay.Features.LevelTasks.Systems;
using Code.Infrastructure.Systems;

namespace Code.Gameplay.Features.LevelTasks
{
    public sealed class LevelTaskFeature : Feature
    {
        public LevelTaskFeature(ISystemFactory systems)
        {
            //amount condition
            Add(systems.Create<UpdateTaskConcreteRabbitMinAmountSystem>());
            Add(systems.Create<UpdateTaskConcreteRabbitAmountRangeSystem>());

            Add(systems.Create<UpdateTaskCommonRabbitMinAmountSystem>());
            Add(systems.Create<UpdateTaskCommonRabbitRangeAmountSystem>());
            
            Add(systems.Create<UpdateTaskRemoveAllRabbitsSystem>());
            
            //time condition
            Add(systems.Create<UpdateTaskTimeLeftSystem>());
            Add(systems.Create<MarkExpiredTimeSystem>());
            Add(systems.Create<MarkTimeDurationConditionFailedSystem>());

            Add(systems.Create<IncreaseLevelTaskHoldDurationTimeSystem>());
            Add(systems.Create<DecreaseLevelTaskHoldDurationTimeSystem>());
            Add(systems.Create<UpdateLevelTaskHoldDurationTimeHasProgressMarkSystem>());

            Add(systems.Create<MarkHoldDurationTimeConditionCompletedSystem>());

            Add(systems.Create<MarkTimeConditionCompletedSystem>());
            
            //finish task
            Add(systems.Create<UpdateTaskStatusPanelSystem>());
            Add(systems.Create<EmitLoseSystem>());
            Add(systems.Create<MarkTaskFailedWhenTimeExpiredSystem>());
            Add(systems.Create<MarkTaskFailedWhenNoChancesSystem>());
            Add(systems.Create<EmitWinSystem>());
            Add(systems.Create<MarkTaskCompletedSystem>());
        }
    }
}