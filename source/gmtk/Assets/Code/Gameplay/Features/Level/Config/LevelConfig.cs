﻿using Code.Gameplay.Features.LevelTasks.Config;
using UnityEngine;

namespace Code.Gameplay.Features.Level.Config
{
    [CreateAssetMenu(menuName = "StaticData/Create Level Config", fileName = "LevelConfig")]
    public class LevelConfig : ScriptableObject
    {
        public string Id;
        public int Index;

        public GameObject LevelPrefab;

        public LevelTaskConfig TaskConfig;

        public IslandData[] IslandsData;
        public StallsSpawnData[] StallsSpawnData;
        public PresetupRabbitData[] PresetupRabbits;
        public InfectionForLevelData[] Infections;
        public PresetupFoxesData[] PresetupFoxesData;
        public PresetupHoleData[] PresetupHoleData;
        public ConveyorBeltData[] ConveyorBelts;

        [TextArea(0,10)]
        public string Hint;
    }
}