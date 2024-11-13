//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherEatingFinished;

    public static Entitas.IMatcher<GameEntity> EatingFinished {
        get {
            if (_matcherEatingFinished == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.EatingFinished);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherEatingFinished = matcher;
            }

            return _matcherEatingFinished;
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

    static readonly Code.Gameplay.Features.Foxes.EatingFinished eatingFinishedComponent = new Code.Gameplay.Features.Foxes.EatingFinished();

    public bool isEatingFinished {
        get { return HasComponent(GameComponentsLookup.EatingFinished); }
        set {
            if (value != isEatingFinished) {
                var index = GameComponentsLookup.EatingFinished;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : eatingFinishedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
