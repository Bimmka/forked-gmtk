//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherLevelTaskDurationBeforeExpiredTimeLeft;

    public static Entitas.IMatcher<GameEntity> LevelTaskDurationBeforeExpiredTimeLeft {
        get {
            if (_matcherLevelTaskDurationBeforeExpiredTimeLeft == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LevelTaskDurationBeforeExpiredTimeLeft);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLevelTaskDurationBeforeExpiredTimeLeft = matcher;
            }

            return _matcherLevelTaskDurationBeforeExpiredTimeLeft;
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

    public Code.Gameplay.Features.LevelTasks.LevelTaskDurationBeforeExpiredTimeLeft levelTaskDurationBeforeExpiredTimeLeft { get { return (Code.Gameplay.Features.LevelTasks.LevelTaskDurationBeforeExpiredTimeLeft)GetComponent(GameComponentsLookup.LevelTaskDurationBeforeExpiredTimeLeft); } }
    public float LevelTaskDurationBeforeExpiredTimeLeft { get { return levelTaskDurationBeforeExpiredTimeLeft.Value; } }
    public bool hasLevelTaskDurationBeforeExpiredTimeLeft { get { return HasComponent(GameComponentsLookup.LevelTaskDurationBeforeExpiredTimeLeft); } }

    public GameEntity AddLevelTaskDurationBeforeExpiredTimeLeft(float newValue) {
        var index = GameComponentsLookup.LevelTaskDurationBeforeExpiredTimeLeft;
        var component = (Code.Gameplay.Features.LevelTasks.LevelTaskDurationBeforeExpiredTimeLeft)CreateComponent(index, typeof(Code.Gameplay.Features.LevelTasks.LevelTaskDurationBeforeExpiredTimeLeft));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceLevelTaskDurationBeforeExpiredTimeLeft(float newValue) {
        var index = GameComponentsLookup.LevelTaskDurationBeforeExpiredTimeLeft;
        var component = (Code.Gameplay.Features.LevelTasks.LevelTaskDurationBeforeExpiredTimeLeft)CreateComponent(index, typeof(Code.Gameplay.Features.LevelTasks.LevelTaskDurationBeforeExpiredTimeLeft));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveLevelTaskDurationBeforeExpiredTimeLeft() {
        RemoveComponent(GameComponentsLookup.LevelTaskDurationBeforeExpiredTimeLeft);
        return this;
    }
}