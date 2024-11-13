//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCanBeChosenForReplication;

    public static Entitas.IMatcher<GameEntity> CanBeChosenForReplication {
        get {
            if (_matcherCanBeChosenForReplication == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CanBeChosenForReplication);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCanBeChosenForReplication = matcher;
            }

            return _matcherCanBeChosenForReplication;
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

    static readonly Code.Gameplay.Features.Rabbits.CanBeChosenForReplication canBeChosenForReplicationComponent = new Code.Gameplay.Features.Rabbits.CanBeChosenForReplication();

    public bool isCanBeChosenForReplication {
        get { return HasComponent(GameComponentsLookup.CanBeChosenForReplication); }
        set {
            if (value != isCanBeChosenForReplication) {
                var index = GameComponentsLookup.CanBeChosenForReplication;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : canBeChosenForReplicationComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}