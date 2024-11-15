//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSinkingIsland;

    public static Entitas.IMatcher<GameEntity> SinkingIsland {
        get {
            if (_matcherSinkingIsland == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SinkingIsland);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSinkingIsland = matcher;
            }

            return _matcherSinkingIsland;
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

    static readonly Code.Gameplay.Features.SinkingIslands.SinkingIsland sinkingIslandComponent = new Code.Gameplay.Features.SinkingIslands.SinkingIsland();

    public bool isSinkingIsland {
        get { return HasComponent(GameComponentsLookup.SinkingIsland); }
        set {
            if (value != isSinkingIsland) {
                var index = GameComponentsLookup.SinkingIsland;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : sinkingIslandComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
