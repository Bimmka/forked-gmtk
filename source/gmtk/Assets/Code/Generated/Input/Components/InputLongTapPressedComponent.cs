//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherLongTapPressed;

    public static Entitas.IMatcher<InputEntity> LongTapPressed {
        get {
            if (_matcherLongTapPressed == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.LongTapPressed);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherLongTapPressed = matcher;
            }

            return _matcherLongTapPressed;
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
public partial class InputEntity {

    static readonly Code.Gameplay.Input.LongTapPressed longTapPressedComponent = new Code.Gameplay.Input.LongTapPressed();

    public bool isLongTapPressed {
        get { return HasComponent(InputComponentsLookup.LongTapPressed); }
        set {
            if (value != isLongTapPressed) {
                var index = InputComponentsLookup.LongTapPressed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : longTapPressedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}