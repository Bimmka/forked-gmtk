//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMaxRabbitsAmountBeforeDive;

    public static Entitas.IMatcher<GameEntity> MaxRabbitsAmountBeforeDive {
        get {
            if (_matcherMaxRabbitsAmountBeforeDive == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MaxRabbitsAmountBeforeDive);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMaxRabbitsAmountBeforeDive = matcher;
            }

            return _matcherMaxRabbitsAmountBeforeDive;
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

    public Code.Gameplay.Features.SinkingIslands.MaxRabbitsAmountBeforeDive maxRabbitsAmountBeforeDive { get { return (Code.Gameplay.Features.SinkingIslands.MaxRabbitsAmountBeforeDive)GetComponent(GameComponentsLookup.MaxRabbitsAmountBeforeDive); } }
    public int MaxRabbitsAmountBeforeDive { get { return maxRabbitsAmountBeforeDive.Value; } }
    public bool hasMaxRabbitsAmountBeforeDive { get { return HasComponent(GameComponentsLookup.MaxRabbitsAmountBeforeDive); } }

    public GameEntity AddMaxRabbitsAmountBeforeDive(int newValue) {
        var index = GameComponentsLookup.MaxRabbitsAmountBeforeDive;
        var component = (Code.Gameplay.Features.SinkingIslands.MaxRabbitsAmountBeforeDive)CreateComponent(index, typeof(Code.Gameplay.Features.SinkingIslands.MaxRabbitsAmountBeforeDive));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceMaxRabbitsAmountBeforeDive(int newValue) {
        var index = GameComponentsLookup.MaxRabbitsAmountBeforeDive;
        var component = (Code.Gameplay.Features.SinkingIslands.MaxRabbitsAmountBeforeDive)CreateComponent(index, typeof(Code.Gameplay.Features.SinkingIslands.MaxRabbitsAmountBeforeDive));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveMaxRabbitsAmountBeforeDive() {
        RemoveComponent(GameComponentsLookup.MaxRabbitsAmountBeforeDive);
        return this;
    }
}