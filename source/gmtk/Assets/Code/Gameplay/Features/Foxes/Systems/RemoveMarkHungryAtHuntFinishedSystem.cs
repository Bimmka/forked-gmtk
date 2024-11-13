﻿using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.Foxes.Systems
{
    public class RemoveMarkHungryAtHuntFinishedSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _foxes;
        private readonly List<GameEntity> _buffer = new List<GameEntity>(32);

        public RemoveMarkHungryAtHuntFinishedSystem(GameContext game)
        {
            _foxes = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Fox,
                    GameMatcher.Hungry,
                    GameMatcher.Alive,
                    GameMatcher.HuntFinished));
        }

        public void Execute()
        {
            foreach (GameEntity fox in _foxes.GetEntities(_buffer))
            {
                fox.isHungry = false;
            }
        }
    }
}