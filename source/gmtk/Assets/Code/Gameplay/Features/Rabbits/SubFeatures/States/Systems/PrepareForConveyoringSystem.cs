﻿using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Rabbits.SubFeatures.States.Systems
{
    public class PrepareForConveyoringSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _rabbits;
        private readonly List<GameEntity> _buffer = new List<GameEntity>(32);

        public PrepareForConveyoringSystem(GameContext game)
        {
            _rabbits = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Rabbit,
                    GameMatcher.ConveyoringStarted,
                    GameMatcher.RabbitAnimator,
                    GameMatcher.Alive,
                    GameMatcher.RabbitVisualChanger));
        }

        public void Execute()
        {
            foreach (GameEntity rabbit in _rabbits.GetEntities(_buffer))
            {
                rabbit.isMoving = false;
                rabbit.isMovementAvailable = false;
                rabbit.isWaitingForMoving = false;
                rabbit.isMovingUp = false;

                rabbit.isWaitingForNextReplicationUp = false;
                rabbit.isReplicationTimeUp = false;
                rabbit.isCanBeChosenForReplication = false;
                rabbit.isCanStartReplication = false;
                rabbit.isWantToReplicate = false;
                rabbit.isMovingToReplicationTarget = false;
                rabbit.isValidReplicationTarget = false;

                rabbit.RabbitAnimator.PlayIdle();

                if (rabbit.hasMoveDirection)
                    rabbit.RemoveMoveDirection();

                rabbit.RabbitVisualChanger.RemoveLove();
            }
        }
    }
}