using Code.Infrastructure.View.Registrars;
using UnityEngine;

namespace Code.Gameplay.Features.Selection.Registrars
{
    public class SelectionBoundsRegistrar : EntityComponentRegistrar
    {
        public Vector2 SelectionBounds;
        public override void RegisterComponents()
        {
            Entity.AddSelectionBounds(SelectionBounds);
        }

        public override void UnregisterComponents()
        {
            if (Entity.hasSelectionBounds)
                Entity.RemoveSelectionBounds();
        }
    }
}