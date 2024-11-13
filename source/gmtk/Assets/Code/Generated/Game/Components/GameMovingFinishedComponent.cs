//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMovingFinished;

    public static Entitas.IMatcher<GameEntity> MovingFinished {
        get {
            if (_matcherMovingFinished == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MovingFinished);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMovingFinished = matcher;
            }

            return _matcherMovingFinished;
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

    static readonly Code.Gameplay.Features.Rabbits.MovingFinished movingFinishedComponent = new Code.Gameplay.Features.Rabbits.MovingFinished();

    public bool isMovingFinished {
        get { return HasComponent(GameComponentsLookup.MovingFinished); }
        set {
            if (value != isMovingFinished) {
                var index = GameComponentsLookup.MovingFinished;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : movingFinishedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}