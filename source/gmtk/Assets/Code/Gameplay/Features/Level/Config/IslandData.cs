using System;
using System.Collections.Generic;
using Code.Gameplay.Features.SinkingIslands.Config;

namespace Code.Gameplay.Features.Level.Config
{
    [Serializable]
    public class IslandData
    {
        public IslandDiveType DiveType;
        public List<int> StallsOnIsland;
        public float ToSurfaceTime = 1.5f;
        public int MaxRabbitsBeforeDive = 8;
        public float NextDiveTime = 5f;
        public float DelayBeforeDive = 1.5f;
    }
}