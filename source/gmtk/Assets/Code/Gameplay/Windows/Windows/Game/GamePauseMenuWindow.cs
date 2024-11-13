﻿using Code.Gameplay.Common.Time;
using Code.Gameplay.Levels;
using Code.Gameplay.Sounds.Config;
using Code.Gameplay.Sounds.Service;
using Code.Gameplay.StaticData;
using Code.Gameplay.Windows.Base;
using Code.Gameplay.Windows.Service;
using Code.Infrastructure.Loading;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Windows.Windows.Game
{
    public class GamePauseMenuWindow : BaseWindow
    {
        public Transform AnimationContent;
        public float ScaleInDuration = 1f;
        public float ScaleOutDuration = 0.5f;
        public Button CloseButton;
        public Button RestartLevelButton;
        public Button SettingsButton;
        public TextMeshProUGUI HintText;

        public string LevelId;

        private ILevelDataProvider _levelDataProvider;
        private IGameStateMachine _gameStateMachine;
        private IStaticDataService _staticDataService;
        private IWindowService _windowService;
        private ITimeService _timeService;
        private IAudioService _audioService;

        [Inject]
        private void Construct(
            IWindowService windowService,
            IStaticDataService staticDataService,
            IGameStateMachine gameStateMachine,
            ILevelDataProvider levelDataProvider,
            ITimeService timeService,
            IAudioService audioService)
        {
            _audioService = audioService;
            _timeService = timeService;
            _levelDataProvider = levelDataProvider;
            _gameStateMachine = gameStateMachine;
            _staticDataService = staticDataService;
            _windowService = windowService;
        }
        
        protected override void Initialize()
        {
            base.Initialize();
            Id = WindowId.PauseMenu;
            
            AnimationContent.localScale = Vector3.zero;
            AnimationContent.DOScale(Vector3.one, ScaleInDuration).SetEase(Ease.InOutSine);

            LevelId = _levelDataProvider.CurrentId;
            HintText.text = _staticDataService.GetLevelConfig(LevelId).Hint;
            
            _timeService.StopTime();
        }
        
        protected override void SubscribeUpdates()
        {
            base.SubscribeUpdates();
            CloseButton.onClick.AddListener(Close);
            RestartLevelButton.onClick.AddListener(RestartLevel);
            SettingsButton.onClick.AddListener(OpenSettings);
        }

        protected override void UnsubscribeUpdates()
        {
            base.UnsubscribeUpdates();
            CloseButton.onClick.RemoveListener(Close);
            RestartLevelButton.onClick.RemoveListener(RestartLevel);
            SettingsButton.onClick.RemoveListener(OpenSettings);
            _timeService.StartTime();
        }
        
        private void Close()
        {
            _windowService.Close(Id);
            _timeService.StartTime();
            
            AnimationContent.DOScale(Vector3.zero, ScaleOutDuration).SetEase(Ease.InOutSine);
        }

        private void RestartLevel()
        {
            _audioService.PlayAudio(SoundType.UIClick);
            _levelDataProvider.SetCurrentId(LevelId);
            _gameStateMachine.Enter<LoadingHomeScreenState>();
        }

        private void OpenSettings()
        {
            _audioService.PlayAudio(SoundType.UIClick);
            _windowService.Open(WindowId.Settings);
        }
    }
}