//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSurfaced;

    public static Entitas.IMatcher<GameEntity> Surfaced {
        get {
            if (_matcherSurfaced == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Surfaced);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSurfaced = matcher;
            }

            return _matcherSurfaced;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Code.Gameplay.Features.SinkingIslands.Surfaced surfacedComponent = new Code.Gameplay.Features.SinkingIslands.Surfaced();

    public bool isSurfaced {
        get { return HasComponent(GameComponentsLookup.Surfaced); }
        set {
            if (value != isSurfaced) {
                var index = GameComponentsLookup.Surfaced;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : surfacedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
