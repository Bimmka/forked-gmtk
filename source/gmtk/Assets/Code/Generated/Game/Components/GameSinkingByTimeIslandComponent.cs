//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSinkingByTimeIsland;

    public static Entitas.IMatcher<GameEntity> SinkingByTimeIsland {
        get {
            if (_matcherSinkingByTimeIsland == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SinkingByTimeIsland);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSinkingByTimeIsland = matcher;
            }

            return _matcherSinkingByTimeIsland;
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

    static readonly Code.Gameplay.Features.SinkingIslands.SinkingByTimeIsland sinkingByTimeIslandComponent = new Code.Gameplay.Features.SinkingIslands.SinkingByTimeIsland();

    public bool isSinkingByTimeIsland {
        get { return HasComponent(GameComponentsLookup.SinkingByTimeIsland); }
        set {
            if (value != isSinkingByTimeIsland) {
                var index = GameComponentsLookup.SinkingByTimeIsland;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : sinkingByTimeIslandComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}