//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSpawnAmount;

    public static Entitas.IMatcher<GameEntity> SpawnAmount {
        get {
            if (_matcherSpawnAmount == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SpawnAmount);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSpawnAmount = matcher;
            }

            return _matcherSpawnAmount;
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

    public Code.Gameplay.Features.Holes.SpawnAmount spawnAmount { get { return (Code.Gameplay.Features.Holes.SpawnAmount)GetComponent(GameComponentsLookup.SpawnAmount); } }
    public int SpawnAmount { get { return spawnAmount.Value; } }
    public bool hasSpawnAmount { get { return HasComponent(GameComponentsLookup.SpawnAmount); } }

    public GameEntity AddSpawnAmount(int newValue) {
        var index = GameComponentsLookup.SpawnAmount;
        var component = (Code.Gameplay.Features.Holes.SpawnAmount)CreateComponent(index, typeof(Code.Gameplay.Features.Holes.SpawnAmount));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceSpawnAmount(int newValue) {
        var index = GameComponentsLookup.SpawnAmount;
        var component = (Code.Gameplay.Features.Holes.SpawnAmount)CreateComponent(index, typeof(Code.Gameplay.Features.Holes.SpawnAmount));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveSpawnAmount() {
        RemoveComponent(GameComponentsLookup.SpawnAmount);
        return this;
    }
}