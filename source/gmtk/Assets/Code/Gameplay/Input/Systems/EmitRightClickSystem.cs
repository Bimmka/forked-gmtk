﻿using Code.Common.Entity;
using Code.Common.Extensions;
using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Input.Systems
{
    public class EmitRightClickSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<InputEntity> _inputs;
        public EmitRightClickSystem(InputContext meta, ITimeService time)
        {
            _time = time;
            _inputs = meta.GetGroup(InputMatcher
                .AllOf(
                    InputMatcher.Input,
                    InputMatcher.RightMouseUp,
                    InputMatcher.LastRightMouseDownTime,
                    InputMatcher.ScreenMousePosition,
                    InputMatcher.WorldMousePosition,
                    InputMatcher.ClickInterval,
                    InputMatcher.ClickableLayerMask)
                .NoneOf(InputMatcher.Dragging));
        }

        public void Execute()
        {
            foreach (InputEntity input in _inputs)
            {
                if ((_time.Time - input.LastRightMouseDownTime) <= input.ClickInterval)
                {
                    CreateInputEntity
                        .Empty()
                        .AddScreenMousePosition(input.ScreenMousePosition)
                        .AddWorldMousePosition(input.WorldMousePosition)
                        .With(x => x.isEmptyClicked = true)
                        .With(x => x.isRightClick = true);
                }
            }
        }
    }
}