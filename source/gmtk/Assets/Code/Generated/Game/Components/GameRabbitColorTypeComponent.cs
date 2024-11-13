//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherRabbitColorType;

    public static Entitas.IMatcher<GameEntity> RabbitColorType {
        get {
            if (_matcherRabbitColorType == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.RabbitColorType);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherRabbitColorType = matcher;
            }

            return _matcherRabbitColorType;
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

    public Code.Gameplay.Features.Rabbits.RabbitColorTypeComponent rabbitColorType { get { return (Code.Gameplay.Features.Rabbits.RabbitColorTypeComponent)GetComponent(GameComponentsLookup.RabbitColorType); } }
    public Code.Gameplay.Features.Rabbits.Config.Rabbits.RabbitColorType RabbitColorType { get { return rabbitColorType.Value; } }
    public bool hasRabbitColorType { get { return HasComponent(GameComponentsLookup.RabbitColorType); } }

    public GameEntity AddRabbitColorType(Code.Gameplay.Features.Rabbits.Config.Rabbits.RabbitColorType newValue) {
        var index = GameComponentsLookup.RabbitColorType;
        var component = (Code.Gameplay.Features.Rabbits.RabbitColorTypeComponent)CreateComponent(index, typeof(Code.Gameplay.Features.Rabbits.RabbitColorTypeComponent));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceRabbitColorType(Code.Gameplay.Features.Rabbits.Config.Rabbits.RabbitColorType newValue) {
        var index = GameComponentsLookup.RabbitColorType;
        var component = (Code.Gameplay.Features.Rabbits.RabbitColorTypeComponent)CreateComponent(index, typeof(Code.Gameplay.Features.Rabbits.RabbitColorTypeComponent));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveRabbitColorType() {
        RemoveComponent(GameComponentsLookup.RabbitColorType);
        return this;
    }
}
