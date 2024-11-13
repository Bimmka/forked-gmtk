//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherTargetPointReached;

    public static Entitas.IMatcher<GameEntity> TargetPointReached {
        get {
            if (_matcherTargetPointReached == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.TargetPointReached);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherTargetPointReached = matcher;
            }

            return _matcherTargetPointReached;
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

    static readonly Code.Gameplay.Features.Movement.TargetPointReached targetPointReachedComponent = new Code.Gameplay.Features.Movement.TargetPointReached();

    public bool isTargetPointReached {
        get { return HasComponent(GameComponentsLookup.TargetPointReached); }
        set {
            if (value != isTargetPointReached) {
                var index = GameComponentsLookup.TargetPointReached;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : targetPointReachedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}