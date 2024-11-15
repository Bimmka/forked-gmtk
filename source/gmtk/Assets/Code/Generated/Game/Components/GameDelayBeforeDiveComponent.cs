//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDelayBeforeDive;

    public static Entitas.IMatcher<GameEntity> DelayBeforeDive {
        get {
            if (_matcherDelayBeforeDive == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DelayBeforeDive);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDelayBeforeDive = matcher;
            }

            return _matcherDelayBeforeDive;
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

    public Code.Gameplay.Features.SinkingIslands.DelayBeforeDive delayBeforeDive { get { return (Code.Gameplay.Features.SinkingIslands.DelayBeforeDive)GetComponent(GameComponentsLookup.DelayBeforeDive); } }
    public float DelayBeforeDive { get { return delayBeforeDive.Value; } }
    public bool hasDelayBeforeDive { get { return HasComponent(GameComponentsLookup.DelayBeforeDive); } }

    public GameEntity AddDelayBeforeDive(float newValue) {
        var index = GameComponentsLookup.DelayBeforeDive;
        var component = (Code.Gameplay.Features.SinkingIslands.DelayBeforeDive)CreateComponent(index, typeof(Code.Gameplay.Features.SinkingIslands.DelayBeforeDive));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceDelayBeforeDive(float newValue) {
        var index = GameComponentsLookup.DelayBeforeDive;
        var component = (Code.Gameplay.Features.SinkingIslands.DelayBeforeDive)CreateComponent(index, typeof(Code.Gameplay.Features.SinkingIslands.DelayBeforeDive));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveDelayBeforeDive() {
        RemoveComponent(GameComponentsLookup.DelayBeforeDive);
        return this;
    }
}
