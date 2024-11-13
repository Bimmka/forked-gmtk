using Entitas;

namespace Code.Gameplay.Features.Selection.SubFeatures.Release.Systems
{
    public class MarkReleaseUpSelectedSociopathEntitiesSystem : IExecuteSystem
    {
        private readonly GameContext _game;
        private readonly IGroup<GameEntity> _selections;

        public MarkReleaseUpSelectedSociopathEntitiesSystem(GameContext game)
        {
            _game = game;
            
            _selections = game.GetGroup(GameMatcher
                .AllOf(
                    GameMatcher.HasSelections,
                    GameMatcher.Dragging,
                    GameMatcher.SelectedEntities));
        }

        public void Execute()
        {
            foreach (GameEntity selection in _selections)
            {
                int selectedEntitiesAmount = selection.SelectedEntities.Count;

                foreach (int selectedEntity in selection.SelectedEntities)
                {
                    var selected = _game.GetEntityWithId(selectedEntity);
                    
                    if (selected == null)
                        continue;

                    if (selected.isSociopath && selected.isAlive && selected.isDragStarted == false && selectedEntitiesAmount > 1)
                        selected.isReleaseFromDragUp = true;
                }
            }
        }
    }
}