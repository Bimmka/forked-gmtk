using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Input.Systems
{
    public class CleanupRightClicksSystem : ICleanupSystem
    {
        private readonly IGroup<InputEntity> _clicks;
        private readonly List<InputEntity> _buffer = new(2);

        public CleanupRightClicksSystem(InputContext input)
        {
            _clicks = input.GetGroup(InputMatcher.AllOf(InputMatcher.RightClick));
        }

        public void Cleanup()
        {
            foreach (InputEntity click in _clicks.GetEntities(_buffer))
            {
                click.Destroy();
            }
        }
    }
}