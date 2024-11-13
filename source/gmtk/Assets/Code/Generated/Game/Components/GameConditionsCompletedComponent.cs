//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherConditionsCompleted;

    public static Entitas.IMatcher<GameEntity> ConditionsCompleted {
        get {
            if (_matcherConditionsCompleted == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ConditionsCompleted);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherConditionsCompleted = matcher;
            }

            return _matcherConditionsCompleted;
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

    static readonly Code.Gameplay.Features.LevelTasks.ConditionsCompleted conditionsCompletedComponent = new Code.Gameplay.Features.LevelTasks.ConditionsCompleted();

    public bool isConditionsCompleted {
        get { return HasComponent(GameComponentsLookup.ConditionsCompleted); }
        set {
            if (value != isConditionsCompleted) {
                var index = GameComponentsLookup.ConditionsCompleted;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : conditionsCompletedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
