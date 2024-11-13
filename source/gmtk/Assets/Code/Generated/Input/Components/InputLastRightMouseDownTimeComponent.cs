//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherLastRightMouseDownTime;

    public static Entitas.IMatcher<InputEntity> LastRightMouseDownTime {
        get {
            if (_matcherLastRightMouseDownTime == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.LastRightMouseDownTime);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherLastRightMouseDownTime = matcher;
            }

            return _matcherLastRightMouseDownTime;
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

    public Code.Gameplay.Input.LastRightMouseDownTime lastRightMouseDownTime { get { return (Code.Gameplay.Input.LastRightMouseDownTime)GetComponent(InputComponentsLookup.LastRightMouseDownTime); } }
    public float LastRightMouseDownTime { get { return lastRightMouseDownTime.Value; } }
    public bool hasLastRightMouseDownTime { get { return HasComponent(InputComponentsLookup.LastRightMouseDownTime); } }

    public InputEntity AddLastRightMouseDownTime(float newValue) {
        var index = InputComponentsLookup.LastRightMouseDownTime;
        var component = (Code.Gameplay.Input.LastRightMouseDownTime)CreateComponent(index, typeof(Code.Gameplay.Input.LastRightMouseDownTime));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public InputEntity ReplaceLastRightMouseDownTime(float newValue) {
        var index = InputComponentsLookup.LastRightMouseDownTime;
        var component = (Code.Gameplay.Input.LastRightMouseDownTime)CreateComponent(index, typeof(Code.Gameplay.Input.LastRightMouseDownTime));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public InputEntity RemoveLastRightMouseDownTime() {
        RemoveComponent(InputComponentsLookup.LastRightMouseDownTime);
        return this;
    }
}
