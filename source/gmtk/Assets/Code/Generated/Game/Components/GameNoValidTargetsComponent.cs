//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherNoValidTargets;

    public static Entitas.IMatcher<GameEntity> NoValidTargets {
        get {
            if (_matcherNoValidTargets == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.NoValidTargets);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherNoValidTargets = matcher;
            }

            return _matcherNoValidTargets;
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

    static readonly Code.Gameplay.Features.Foxes.NoValidTargets noValidTargetsComponent = new Code.Gameplay.Features.Foxes.NoValidTargets();

    public bool isNoValidTargets {
        get { return HasComponent(GameComponentsLookup.NoValidTargets); }
        set {
            if (value != isNoValidTargets) {
                var index = GameComponentsLookup.NoValidTargets;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : noValidTargetsComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}