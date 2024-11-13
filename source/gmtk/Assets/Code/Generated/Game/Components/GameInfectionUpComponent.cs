//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherInfectionUp;

    public static Entitas.IMatcher<GameEntity> InfectionUp {
        get {
            if (_matcherInfectionUp == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InfectionUp);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInfectionUp = matcher;
            }

            return _matcherInfectionUp;
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

    static readonly Code.Gameplay.Features.Infections.InfectionUp infectionUpComponent = new Code.Gameplay.Features.Infections.InfectionUp();

    public bool isInfectionUp {
        get { return HasComponent(GameComponentsLookup.InfectionUp); }
        set {
            if (value != isInfectionUp) {
                var index = GameComponentsLookup.InfectionUp;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : infectionUpComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}