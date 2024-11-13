using System;
using Code.Gameplay.Features.Rabbits.Config.Rabbits;
#if UNITY_EDITOR
using Sirenix.OdinInspector;
#endif

namespace Code.Gameplay.Features.LevelTasks.Config
{
    [Serializable]
    public class TaskGoalByRabbitColor
    {
        public RabbitColorType ColorType;
        public int MinAmount;
        
#if UNITY_EDITOR
        [HideIf(nameof(_isMaxAmountHidden))]
#endif
        public int MaxAmount;
        
        private bool _isMaxAmountHidden;

        
        public void SetMaxAmountHiddenValue(bool isHidden)
        {
            _isMaxAmountHidden = isHidden;
        }
    }
}