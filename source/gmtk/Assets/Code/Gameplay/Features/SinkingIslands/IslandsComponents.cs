using System.Collections.Generic;
using Entitas;

namespace Code.Gameplay.Features.SinkingIslands
{
    [Game] public class SinkingIsland : IComponent {}
    [Game] public class SinkingByTimeIsland : IComponent {}
    [Game] public class SinkingByWeightIsland : IComponent {}
    
    [Game] public class Sunken : IComponent {}
    [Game] public class JustSunken : IComponent {}
    [Game] public class Surfaced : IComponent {}
    [Game] public class WaitingDiveIsland : IComponent {}
    [Game] public class WaitingSurfaceIsland : IComponent {}
    
    [Game] public class NextDiveTime : IComponent { public float Value; }
    [Game] public class NextDiveTimeLeft : IComponent { public float Value; }
    
    [Game] public class MaxRabbitsAmountBeforeDive : IComponent { public int Value; }
    [Game] public class CurrentRabbitsAmountBeforeDive : IComponent { public int Value; }
    
    [Game] public class ToSurfaceTime : IComponent { public float Value; }
    [Game] public class ToSurfaceTimeLeft : IComponent { public float Value; }
    
    [Game] public class DelayBeforeDive : IComponent { public float Value; }
    [Game] public class DelayBeforeDiveLeft : IComponent { public float Value; }
    
    [Game] public class IslandStalls : IComponent { public List<int> Value; }
    
    [Game] public class StayOnIsland : IComponent {}
}