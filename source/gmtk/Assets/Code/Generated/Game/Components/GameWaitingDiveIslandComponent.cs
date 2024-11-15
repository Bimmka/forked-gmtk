//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherWaitingDiveIsland;

    public static Entitas.IMatcher<GameEntity> WaitingDiveIsland {
        get {
            if (_matcherWaitingDiveIsland == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WaitingDiveIsland);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWaitingDiveIsland = matcher;
            }

            return _matcherWaitingDiveIsland;
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

    static readonly Code.Gameplay.Features.SinkingIslands.WaitingDiveIsland waitingDiveIslandComponent = new Code.Gameplay.Features.SinkingIslands.WaitingDiveIsland();

    public bool isWaitingDiveIsland {
        get { return HasComponent(GameComponentsLookup.WaitingDiveIsland); }
        set {
            if (value != isWaitingDiveIsland) {
                var index = GameComponentsLookup.WaitingDiveIsland;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : waitingDiveIslandComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
