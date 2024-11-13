//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCanStartReplication;

    public static Entitas.IMatcher<GameEntity> CanStartReplication {
        get {
            if (_matcherCanStartReplication == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CanStartReplication);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCanStartReplication = matcher;
            }

            return _matcherCanStartReplication;
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

    static readonly Code.Gameplay.Features.Rabbits.CanStartReplication canStartReplicationComponent = new Code.Gameplay.Features.Rabbits.CanStartReplication();

    public bool isCanStartReplication {
        get { return HasComponent(GameComponentsLookup.CanStartReplication); }
        set {
            if (value != isCanStartReplication) {
                var index = GameComponentsLookup.CanStartReplication;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : canStartReplicationComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
