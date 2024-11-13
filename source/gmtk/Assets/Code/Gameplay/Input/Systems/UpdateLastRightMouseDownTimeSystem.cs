using Code.Gameplay.Common.Time;
using Entitas;

namespace Code.Gameplay.Input.Systems
{
    public class UpdateLastRightMouseDownTimeSystem : IExecuteSystem
    {
        private readonly ITimeService _time;
        private readonly IGroup<InputEntity> _inputs;
        public UpdateLastRightMouseDownTimeSystem(InputContext meta, ITimeService time)
        {
            _time = time;
            _inputs = meta.GetGroup(InputMatcher
                .AllOf(
                    InputMatcher.Input,
                    InputMatcher.RightMouseDown,
                    InputMatcher.LastRightMouseDownTime));
        }

        public void Execute()
        {
            foreach (InputEntity input in _inputs)
            {
                input.ReplaceLastRightMouseDownTime(_time.Time);
            }
        }
    }
}