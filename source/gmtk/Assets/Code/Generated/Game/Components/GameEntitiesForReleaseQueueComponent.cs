//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEntitiesForReleaseQueue;

    public static Entitas.IMatcher<GameEntity> EntitiesForReleaseQueue {
        get {
            if (_matcherEntitiesForReleaseQueue == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EntitiesForReleaseQueue);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEntitiesForReleaseQueue = matcher;
            }

            return _matcherEntitiesForReleaseQueue;
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

    public Code.Gameplay.Features.Selection.EntitiesForReleaseQueue entitiesForReleaseQueue { get { return (Code.Gameplay.Features.Selection.EntitiesForReleaseQueue)GetComponent(GameComponentsLookup.EntitiesForReleaseQueue); } }
    public System.Collections.Generic.Queue<int> EntitiesForReleaseQueue { get { return entitiesForReleaseQueue.Value; } }
    public bool hasEntitiesForReleaseQueue { get { return HasComponent(GameComponentsLookup.EntitiesForReleaseQueue); } }

    public GameEntity AddEntitiesForReleaseQueue(System.Collections.Generic.Queue<int> newValue) {
        var index = GameComponentsLookup.EntitiesForReleaseQueue;
        var component = (Code.Gameplay.Features.Selection.EntitiesForReleaseQueue)CreateComponent(index, typeof(Code.Gameplay.Features.Selection.EntitiesForReleaseQueue));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceEntitiesForReleaseQueue(System.Collections.Generic.Queue<int> newValue) {
        var index = GameComponentsLookup.EntitiesForReleaseQueue;
        var component = (Code.Gameplay.Features.Selection.EntitiesForReleaseQueue)CreateComponent(index, typeof(Code.Gameplay.Features.Selection.EntitiesForReleaseQueue));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveEntitiesForReleaseQueue() {
        RemoveComponent(GameComponentsLookup.EntitiesForReleaseQueue);
        return this;
    }
}
