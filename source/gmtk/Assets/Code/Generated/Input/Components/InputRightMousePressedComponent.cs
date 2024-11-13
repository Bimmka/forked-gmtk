//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherRightMousePressed;

    public static Entitas.IMatcher<InputEntity> RightMousePressed {
        get {
            if (_matcherRightMousePressed == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.RightMousePressed);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherRightMousePressed = matcher;
            }

            return _matcherRightMousePressed;
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

    static readonly Code.Gameplay.Input.RightMousePressed rightMousePressedComponent = new Code.Gameplay.Input.RightMousePressed();

    public bool isRightMousePressed {
        get { return HasComponent(InputComponentsLookup.RightMousePressed); }
        set {
            if (value != isRightMousePressed) {
                var index = InputComponentsLookup.RightMousePressed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : rightMousePressedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}