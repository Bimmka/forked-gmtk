//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCanSpawnRecessive;

    public static Entitas.IMatcher<GameEntity> CanSpawnRecessive {
        get {
            if (_matcherCanSpawnRecessive == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CanSpawnRecessive);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCanSpawnRecessive = matcher;
            }

            return _matcherCanSpawnRecessive;
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

    static readonly Code.Gameplay.Features.Rabbits.CanSpawnRecessive canSpawnRecessiveComponent = new Code.Gameplay.Features.Rabbits.CanSpawnRecessive();

    public bool isCanSpawnRecessive {
        get { return HasComponent(GameComponentsLookup.CanSpawnRecessive); }
        set {
            if (value != isCanSpawnRecessive) {
                var index = GameComponentsLookup.CanSpawnRecessive;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : canSpawnRecessiveComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}