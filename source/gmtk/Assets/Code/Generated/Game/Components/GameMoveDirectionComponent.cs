//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherMoveDirection;

    public static Entitas.IMatcher<GameEntity> MoveDirection {
        get {
            if (_matcherMoveDirection == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.MoveDirection);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherMoveDirection = matcher;
            }

            return _matcherMoveDirection;
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

    public Code.Gameplay.Features.Movement.MoveDirection moveDirection { get { return (Code.Gameplay.Features.Movement.MoveDirection)GetComponent(GameComponentsLookup.MoveDirection); } }
    public UnityEngine.Vector2 MoveDirection { get { return moveDirection.Value; } }
    public bool hasMoveDirection { get { return HasComponent(GameComponentsLookup.MoveDirection); } }

    public GameEntity AddMoveDirection(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.MoveDirection;
        var component = (Code.Gameplay.Features.Movement.MoveDirection)CreateComponent(index, typeof(Code.Gameplay.Features.Movement.MoveDirection));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceMoveDirection(UnityEngine.Vector2 newValue) {
        var index = GameComponentsLookup.MoveDirection;
        var component = (Code.Gameplay.Features.Movement.MoveDirection)CreateComponent(index, typeof(Code.Gameplay.Features.Movement.MoveDirection));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveMoveDirection() {
        RemoveComponent(GameComponentsLookup.MoveDirection);
        return this;
    }
}