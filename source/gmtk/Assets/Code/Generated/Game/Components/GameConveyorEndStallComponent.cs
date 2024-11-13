//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherConveyorEndStall;

    public static Entitas.IMatcher<GameEntity> ConveyorEndStall {
        get {
            if (_matcherConveyorEndStall == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ConveyorEndStall);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherConveyorEndStall = matcher;
            }

            return _matcherConveyorEndStall;
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

    public Code.Gameplay.Features.ConveyorBelt.ConveyorEndStall conveyorEndStall { get { return (Code.Gameplay.Features.ConveyorBelt.ConveyorEndStall)GetComponent(GameComponentsLookup.ConveyorEndStall); } }
    public int ConveyorEndStall { get { return conveyorEndStall.Value; } }
    public bool hasConveyorEndStall { get { return HasComponent(GameComponentsLookup.ConveyorEndStall); } }

    public GameEntity AddConveyorEndStall(int newValue) {
        var index = GameComponentsLookup.ConveyorEndStall;
        var component = (Code.Gameplay.Features.ConveyorBelt.ConveyorEndStall)CreateComponent(index, typeof(Code.Gameplay.Features.ConveyorBelt.ConveyorEndStall));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceConveyorEndStall(int newValue) {
        var index = GameComponentsLookup.ConveyorEndStall;
        var component = (Code.Gameplay.Features.ConveyorBelt.ConveyorEndStall)CreateComponent(index, typeof(Code.Gameplay.Features.ConveyorBelt.ConveyorEndStall));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveConveyorEndStall() {
        RemoveComponent(GameComponentsLookup.ConveyorEndStall);
        return this;
    }
}
