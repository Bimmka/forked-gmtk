//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherCarrierOfInfection;

    public static Entitas.IMatcher<GameEntity> CarrierOfInfection {
        get {
            if (_matcherCarrierOfInfection == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.CarrierOfInfection);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherCarrierOfInfection = matcher;
            }

            return _matcherCarrierOfInfection;
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

    static readonly Code.Gameplay.Features.Infections.CarrierOfInfection carrierOfInfectionComponent = new Code.Gameplay.Features.Infections.CarrierOfInfection();

    public bool isCarrierOfInfection {
        get { return HasComponent(GameComponentsLookup.CarrierOfInfection); }
        set {
            if (value != isCarrierOfInfection) {
                var index = GameComponentsLookup.CarrierOfInfection;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : carrierOfInfectionComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}