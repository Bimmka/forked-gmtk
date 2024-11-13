﻿using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Features.Rabbits.SubFeatures.Replication.Systems
{
    public class UpdateTimeForNextReplicationSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<GameEntity> _rabbits;

        public UpdateTimeForNextReplicationSystem(GameContext game, ITimeService time)
        {
            _time = time;

            _rabbits = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Rabbit,
                    GameMatcher.Alive,
                    GameMatcher.TimeLeftForNextReplication,
                    GameMatcher.ReplicationAvailable,
                    GameMatcher.WaitingForNextReplicationUp));
        }

        public void Execute()
        {
            foreach (GameEntity rabbit in _rabbits)
            {
                rabbit.ReplaceTimeLeftForNextReplication(rabbit.TimeLeftForNextReplication - _time.DeltaTime);

                if (rabbit.TimeLeftForNextReplication <= 0)
                    rabbit.isReplicationTimeUp = true;
            }
        }
    }
}