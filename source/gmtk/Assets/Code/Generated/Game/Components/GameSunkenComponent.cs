//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSunken;

    public static Entitas.IMatcher<GameEntity> Sunken {
        get {
            if (_matcherSunken == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Sunken);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSunken = matcher;
            }

            return _matcherSunken;
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

    static readonly Code.Gameplay.Features.SinkingIslands.Sunken sunkenComponent = new Code.Gameplay.Features.SinkingIslands.Sunken();

    public bool isSunken {
        get { return HasComponent(GameComponentsLookup.Sunken); }
        set {
            if (value != isSunken) {
                var index = GameComponentsLookup.Sunken;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : sunkenComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}