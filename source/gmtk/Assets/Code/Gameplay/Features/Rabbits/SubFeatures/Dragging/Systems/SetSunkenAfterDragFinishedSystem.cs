using Code.Gameplay.Features.Stalls.Services;
using Entitas;

namespace Code.Gameplay.Features.Rabbits.SubFeatures.Dragging.Systems
{
    public class SetSunkenAfterDragFinishedSystem : IExecuteSystem
    {
        private readonly IStallService _stallService;
        private readonly IGroup<GameEntity> _rabbits;

        public SetSunkenAfterDragFinishedSystem(GameContext game, IStallService stallService)
        {
            _stallService = stallService;
            _rabbits = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.Rabbit,
                    GameMatcher.Alive,
                    GameMatcher.DragFinished,
                    GameMatcher.StallParentIndex));
        }

        public void Execute()
        {
            foreach (GameEntity rabbit in _rabbits)
            {
                GameEntity stall = _stallService.GetStallEntityByIndex(rabbit.StallParentIndex);
                
                if (stall == null)
                    continue;

                if (stall.isSunken)
                    rabbit.isSunken = true;
            }
        }
    }
}