//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCurrentReplicationDuration;

    public static Entitas.IMatcher<GameEntity> CurrentReplicationDuration {
        get {
            if (_matcherCurrentReplicationDuration == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CurrentReplicationDuration);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCurrentReplicationDuration = matcher;
            }

            return _matcherCurrentReplicationDuration;
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

    public Code.Gameplay.Features.Rabbits.CurrentReplicationDuration currentReplicationDuration { get { return (Code.Gameplay.Features.Rabbits.CurrentReplicationDuration)GetComponent(GameComponentsLookup.CurrentReplicationDuration); } }
    public float CurrentReplicationDuration { get { return currentReplicationDuration.Value; } }
    public bool hasCurrentReplicationDuration { get { return HasComponent(GameComponentsLookup.CurrentReplicationDuration); } }

    public GameEntity AddCurrentReplicationDuration(float newValue) {
        var index = GameComponentsLookup.CurrentReplicationDuration;
        var component = (Code.Gameplay.Features.Rabbits.CurrentReplicationDuration)CreateComponent(index, typeof(Code.Gameplay.Features.Rabbits.CurrentReplicationDuration));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceCurrentReplicationDuration(float newValue) {
        var index = GameComponentsLookup.CurrentReplicationDuration;
        var component = (Code.Gameplay.Features.Rabbits.CurrentReplicationDuration)CreateComponent(index, typeof(Code.Gameplay.Features.Rabbits.CurrentReplicationDuration));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveCurrentReplicationDuration() {
        RemoveComponent(GameComponentsLookup.CurrentReplicationDuration);
        return this;
    }
}
