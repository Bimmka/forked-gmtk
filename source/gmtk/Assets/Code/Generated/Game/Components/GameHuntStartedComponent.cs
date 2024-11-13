//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherHuntStarted;

    public static Entitas.IMatcher<GameEntity> HuntStarted {
        get {
            if (_matcherHuntStarted == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HuntStarted);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHuntStarted = matcher;
            }

            return _matcherHuntStarted;
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

    static readonly Code.Gameplay.Features.Foxes.HuntStarted huntStartedComponent = new Code.Gameplay.Features.Foxes.HuntStarted();

    public bool isHuntStarted {
        get { return HasComponent(GameComponentsLookup.HuntStarted); }
        set {
            if (value != isHuntStarted) {
                var index = GameComponentsLookup.HuntStarted;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : huntStartedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
