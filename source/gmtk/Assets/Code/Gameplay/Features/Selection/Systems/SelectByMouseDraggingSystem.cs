using System.Collections.Generic;
using Code.Gameplay.Common.Physics;
using Entitas;
using Unity.Mathematics;
using UnityEngine;

namespace Code.Gameplay.Features.Selection.Systems
{
    public class SelectByMouseDraggingSystem : IExecuteSystem
    {
        private readonly IPhysicsService _physicsService;
        private readonly IGroup<GameEntity> _selections;
        private readonly IGroup<InputEntity> _inputs;
        private readonly IGroup<GameEntity> _selectables;
        private readonly List<GameEntity> _buffer = new List<GameEntity>(1);

        public SelectByMouseDraggingSystem(GameContext game, InputContext input, IPhysicsService physicsService)
        {
            _physicsService = physicsService;
            _selections = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Selection,
                    GameMatcher.WaitingMouseDragFinish));
            
            _inputs = input.GetGroup(InputMatcher
                .AllOf(
                    InputMatcher.Input,
                    InputMatcher.RightMouseUp,
                    InputMatcher.StartMouseDownWorldPosition,
                    InputMatcher.WorldMousePosition,
                    InputMatcher.WasDragging));

            _selectables = game.GetGroup(GameMatcher
                .AllOf(
                GameMatcher.Selectable,
                GameMatcher.WorldPosition,
                GameMatcher.Alive));
        }

        public void Execute()
        {
            foreach (InputEntity input in _inputs)
            {
                foreach (GameEntity selection in _selections.GetEntities(_buffer))
                {
                    Vector2 selectionAreaCenter = (input.StartMouseDownWorldPosition + input.WorldMousePosition) / 2;
                    Vector2 halfSelectionBounds = new Vector2(
                        Mathf.Max(Mathf.Abs(input.StartMouseDownWorldPosition.x - input.WorldMousePosition.x), 0.01f),
                        Mathf.Max(Mathf.Abs(input.StartMouseDownWorldPosition.y - input.WorldMousePosition.y), 0.01f)) / 2;
                    
                    foreach (GameEntity selectable in _selectables)
                    {
                        if (IsInSelectionArea(selectable, selectionAreaCenter, halfSelectionBounds))
                            selection.EntitiesForSelectionQueue.Enqueue(selectable.Id);
                    }

                    selection.isUnselectSelectedEntities = true;

                    selection.isWaitingMouseDragFinish = false;
                }
            }
        }

        private bool IsInSelectionArea(GameEntity selectable, Vector2 selectionAreaCenter, Vector2 halfSelectionBounds)
        {
            if (selectable.hasSelectionBounds && IsSelectBoundsInSelectionArea(selectable, selectionAreaCenter, halfSelectionBounds))
            {
                return true;
            }

            if (selectable.hasSelectionBounds == false && IsDotInSelectionArea(selectable.WorldPosition, selectionAreaCenter, halfSelectionBounds))
            {
                return true;
            }

            return false;
        }

        private bool IsDotInSelectionArea(Vector3 selectableDot, Vector2 selectionAreaCenter, Vector2 halfSelectionBounds)
        {
            return selectableDot.x >= selectionAreaCenter.x - halfSelectionBounds.x
                   && selectableDot.x <= selectionAreaCenter.x + halfSelectionBounds.x
                   && selectableDot.y >= selectionAreaCenter.y - halfSelectionBounds.y
                   && selectableDot.y <= selectionAreaCenter.y + halfSelectionBounds.y;
        }

        //check that projections cross
        private bool IsSelectBoundsInSelectionArea(GameEntity selectable, Vector2 selectionAreaCenter, Vector2 halfSelectionBounds)
        {
            Vector3 halfSelectBounds = selectable.SelectionBounds / 2;
            float leftXSelectBoundPosition = selectable.WorldPosition.x - halfSelectBounds.x;
            float rightXSelectionPosition = selectionAreaCenter.x + halfSelectionBounds.x;

            if (leftXSelectBoundPosition > rightXSelectionPosition)
                return false;
            
            float rightXSelectBoundPosition = selectable.WorldPosition.x + halfSelectBounds.x;
            float leftXSelectionPosition = selectionAreaCenter.x - halfSelectionBounds.x;

            if (rightXSelectBoundPosition < leftXSelectionPosition)
                return false;
            
            float downYSelectBoundPosition = selectable.WorldPosition.y - halfSelectBounds.y;
            float upYSelectionPosition = selectionAreaCenter.y + halfSelectionBounds.y;

            if (downYSelectBoundPosition > upYSelectionPosition)
                return false;
            
            float upYSelectBoundPosition = selectable.WorldPosition.y + halfSelectBounds.y;
            float downYSelectionPosition = selectionAreaCenter.y - halfSelectionBounds.y;

            if (upYSelectBoundPosition < downYSelectionPosition)
                return false;

            return true;
        }
    }
}