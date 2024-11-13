using System;
using System.Collections.Generic;
using Sirenix.OdinInspector;


namespace Code.Gameplay.Features.LevelTasks.Config
{
    [Serializable]
    public class LevelTaskConfig
    {
        [OnValueChanged(nameof(ChangeMaxAmountHiddenAvailabilityForTaskGoal))]
        public LevelTaskType TaskType;

        public LevelTaskDurationLimitationType[] DurationLimitation;

        [ShowIf(nameof(IsCanApplyConditionForAmountByTaskType))]
        [OnValueChanged(nameof(ChangeMaxAmountHiddenAvailabilityForTaskGoal))]
        public LevelTaskAmountConditionType AmountCondition;
        
        [ShowIf(nameof(IsConcreteRabbitTaskType))]
        [OnCollectionChanged(nameof(ChangeMaxAmountAvailable))]
        public List<TaskGoalByRabbitColor> TaskGoalsByRabbitColor;
        
        [ShowIf(nameof(IsHasTimeDurationLimitation))]
        public float TaskDurationTime;
        
        [ShowIf(nameof(IsHasTimeHoldLimitation))]
        public float TimeToHold;

        [ShowIf(nameof(IsHasTimeHoldLimitation))]
        public float DecreaseHoldTimeProgressSpeed = 1f;

        [ShowIf(nameof(IsCommonRabbitTaskType))]
        public int MinAmount;
        
        [ShowIf(nameof(IsAvailableMaxAmount))]
        public int MaxAmount;

        private bool IsConcreteRabbitTaskType()
        {
            return TaskType == LevelTaskType.ConcreteRabbitAmount;  
        }
        
        private bool IsCommonRabbitTaskType()
        {
            return TaskType == LevelTaskType.CommonRabbitAmount;  
        }

        private bool IsHasTimeDurationLimitation()
        {
            if (DurationLimitation == null || DurationLimitation.Length == 0)
                return false;

            foreach (LevelTaskDurationLimitationType limitationType in DurationLimitation)
            {
                if (limitationType == LevelTaskDurationLimitationType.TimeDuration)
                    return true;
            }

            return false;
        }
        
        private bool IsHasTimeHoldLimitation()
        {
            if (DurationLimitation == null || DurationLimitation.Length == 0)
                return false;

            foreach (LevelTaskDurationLimitationType limitationType in DurationLimitation)
            {
                if (limitationType == LevelTaskDurationLimitationType.HoldDuration)
                    return true;
            }

            return false;
        }

        private bool IsAvailableMaxAmount()
        {
            return IsCommonRabbitTaskType() && IsRangeAmountCondition();
        }
        
        private bool IsRangeAmountCondition()
        {
            return AmountCondition == LevelTaskAmountConditionType.RangeAmount;  
        }

        private bool IsCanApplyConditionForAmountByTaskType()
        {
            return TaskType != LevelTaskType.RemoveAllRabbits;
        }

        public void ChangeMaxAmountAvailable()
        {
           ChangeMaxAmountHiddenAvailabilityForTaskGoal();
        }
        
         private void ChangeMaxAmountHiddenAvailabilityForTaskGoal()
        {
            if (TaskType != LevelTaskType.ConcreteRabbitAmount)
                return;

            if (TaskGoalsByRabbitColor == null)
                return;

            foreach (TaskGoalByRabbitColor task in TaskGoalsByRabbitColor)
            {
                task.SetMaxAmountHiddenValue(AmountCondition != LevelTaskAmountConditionType.RangeAmount);
            }
        }
    }
}