using Code.Common.EntityIndices;
using Code.Gameplay.Cameras.Provider;
using Code.Gameplay.Common.Collisions;
using Code.Gameplay.Common.Physics;
using Code.Gameplay.Common.Random;
using Code.Gameplay.Common.Time;
using Code.Gameplay.Features.ConveyorBelt.Factory;
using Code.Gameplay.Features.Foxes.Factory;
using Code.Gameplay.Features.Holes.Factory;
using Code.Gameplay.Features.Infections.Factory;
using Code.Gameplay.Features.Level.Service;
using Code.Gameplay.Features.LevelTasks.Factory;
using Code.Gameplay.Features.Rabbits.Factory;
using Code.Gameplay.Features.Rabbits.StateMachine.States;
using Code.Gameplay.Features.SinkingIslands.Factory;
using Code.Gameplay.Features.Stalls.Factory;
using Code.Gameplay.Features.Stalls.Services;
using Code.Gameplay.Features.Statuses.Applier;
using Code.Gameplay.Features.Statuses.Factory;
using Code.Gameplay.Input.Service;
using Code.Gameplay.Levels;
using Code.Gameplay.Sounds.Behaviours;
using Code.Gameplay.Sounds.Factory;
using Code.Gameplay.Sounds.Service;
using Code.Gameplay.StaticData;
using Code.Gameplay.VFX.Factory;
using Code.Gameplay.VFX.Service;
using Code.Gameplay.Windows;
using Code.Gameplay.Windows.Factory;
using Code.Gameplay.Windows.Service;
using Code.Gameplay.Windows.Windows.Game.Factory;
using Code.Gameplay.Windows.Windows.HomeScreen.Factory;
using Code.Gameplay.Windows.Windows.Loading;
using Code.Infrastructure.AssetManagement;
using Code.Infrastructure.Identifiers;
using Code.Infrastructure.Loading;
using Code.Infrastructure.States.Factory;
using Code.Infrastructure.States.GameStates;
using Code.Infrastructure.States.StateMachine;
using Code.Infrastructure.Systems;
using Code.Infrastructure.View.Factory;
using Code.Progress.Provider;
using Code.Progress.SaveLoad;
using RSG;
using UnityEngine;
using UnityEngine.Audio;
using Zenject;

namespace Code.Infrastructure.Installers
{
  public class BootstrapInstaller : MonoInstaller, ICoroutineRunner, IInitializable
  {
    public MainThemeSoundsContainer MainThemeSoundsContainer;
    public LoadingCurtain LoadingCurtain;
    
    public override void InstallBindings()
    {
      BindInputService();
      BindInfrastructureServices();
      BindAssetManagementServices();
      BindCommonServices();
      BindSystemFactory();
      BindUIFactories();
      BindContexts();
      BindGameplayServices();
      BindUIServices();
      BindCameraProvider();
      BindGameplayFactories();
      BindEntityIndices();
      BindStateMachine();
      BindStateFactory();
      BindGameStates();
      BindRabbitStates();
      BindProgressServices();
      BindSoundElements();
      BindLevelLoadingElements();
    }

    private void BindStateMachine()
    {
      Container.BindInterfacesAndSelfTo<GameStateMachine>().AsSingle();
    }

    private void BindStateFactory()
    {
      Container.BindInterfacesAndSelfTo<StateFactory>().AsSingle();
    }

    private void BindGameStates()
    {
      Container.BindInterfacesAndSelfTo<BootstrapState>().AsSingle();
      Container.BindInterfacesAndSelfTo<LoadProgressState>().AsSingle();
      Container.BindInterfacesAndSelfTo<ActualizeProgressState>().AsSingle();
      Container.BindInterfacesAndSelfTo<LoadingHomeScreenState>().AsSingle();
      Container.BindInterfacesAndSelfTo<HomeScreenState>().AsSingle();
      Container.BindInterfacesAndSelfTo<LoadingBattleState>().AsSingle();
      Container.BindInterfacesAndSelfTo<BattleEnterState>().AsSingle();
      Container.BindInterfacesAndSelfTo<BattleLoopState>().AsSingle();
      Container.BindInterfacesAndSelfTo<GameOverState>().AsSingle();
    }

    private void BindRabbitStates()
    {
      Container.BindInterfacesAndSelfTo<RabbitIdleState>().AsTransient();
      Container.BindInterfacesAndSelfTo<RabbitStupidMoveState>().AsTransient();
      Container.BindInterfacesAndSelfTo<RabbitReplicationState>().AsTransient();
      Container.BindInterfacesAndSelfTo<RabbitDraggingState>().AsTransient();
      Container.BindInterfacesAndSelfTo<RabbitDeadState>().AsTransient();
      Container.BindInterfacesAndSelfTo<RabbitWaitReplicationTargetState>().AsTransient();
      Container.BindInterfacesAndSelfTo<RabbitReplicatingState>().AsTransient();
    }

    private void BindContexts()
    {
      Container.Bind<Contexts>().FromInstance(Contexts.sharedInstance).AsSingle();
      
      Container.Bind<GameContext>().FromInstance(Contexts.sharedInstance.game).AsSingle();
      Container.Bind<InputContext>().FromInstance(Contexts.sharedInstance.input).AsSingle();
      Container.Bind<MetaContext>().FromInstance(Contexts.sharedInstance.meta).AsSingle();
    }

    private void BindCameraProvider()
    {
      Container.BindInterfacesAndSelfTo<CameraProvider>().AsSingle();
    }

    private void BindProgressServices()
    {
      Container.Bind<IProgressProvider>().To<ProgressProvider>().AsSingle();
      Container.Bind<ISaveLoadService>().To<SaveLoadService>().AsSingle();
    }

    private void BindGameplayServices()
    {
      Container.Bind<IStaticDataService>().To<StaticDataService>().AsSingle();
      Container.Bind<ILevelDataProvider>().To<LevelDataProvider>().AsSingle();
      Container.Bind<IMenuDataProvider>().To<MenuDataProvider>().AsSingle();
      Container.Bind<IStallService>().To<StallService>().AsSingle();
      Container.Bind<IStatusApplier>().To<StatusApplier>().AsSingle();
      Container.Bind<ITaskService>().To<TaskService>().AsSingle();
      Container.Bind<IAudioService>().To<AudioService>().AsSingle();
    }

    private void BindGameplayFactories()
    {
      Container.Bind<IEntityViewFactory>().To<EntityViewFactory>().AsSingle();
      Container.Bind<IStallsFactory>().To<StallsFactory>().AsSingle();
      Container.Bind<IRabbitFactory>().To<RabbitFactory>().AsSingle();
      Container.Bind<IStatusFactory>().To<StatusFactory>().AsSingle();
      Container.Bind<IInfectionFactory>().To<InfectionFactory>().AsSingle();
      Container.Bind<IFoxFactory>().To<FoxFactory>().AsSingle();
      Container.Bind<IHoleFactory>().To<HoleFactory>().AsSingle();
      Container.Bind<ITaskFactory>().To<TaskFactory>().AsSingle();
      Container.Bind<IVFXFactory>().To<VFXFactory>().AsSingle();
      Container.Bind<IAudioFactory>().To<AudioFactory>().AsSingle();
      Container.Bind<IConveyorBeltFactory>().To<ConveyorBeltFactory>().AsSingle();
      Container.Bind<IIslandFactory>().To<IslandFactory>().AsSingle();
    }

    private void BindEntityIndices()
    {
      Container.BindInterfacesAndSelfTo<GameEntityIndices>().AsSingle();
    }

    private void BindSystemFactory()
    {
      Container.Bind<ISystemFactory>().To<SystemFactory>().AsSingle();
    }

    private void BindInfrastructureServices()
    {
      Container.BindInterfacesTo<BootstrapInstaller>().FromInstance(this).AsSingle();
      Container.Bind<IIdentifierService>().To<IdentifierService>().AsSingle();
    }

    private void BindAssetManagementServices()
    {
      Container.Bind<IAssetProvider>().To<AssetProvider>().AsSingle();
    }

    private void BindCommonServices()
    {
      Container.Bind<IRandomService>().To<UnityRandomService>().AsSingle();
      Container.Bind<ICollisionRegistry>().To<CollisionRegistry>().AsSingle();
      Container.Bind<IPhysicsService>().To<PhysicsService>().AsSingle();
      Container.Bind<ITimeService>().To<UnityTimeService>().AsSingle();
      Container.Bind<ISceneLoader>().To<SceneLoader>().AsSingle();
      Container.Bind<IVFXService>().To<VFXService>().AsSingle();
    }

    private void BindInputService()
    {
      Container.Bind<IInputService>().To<StandaloneInputService>().AsSingle();
    }

    private void BindUIServices()
    {
      Container.Bind<IWindowService>().To<WindowService>().AsSingle();
    }

    private void BindUIFactories()
    {
      Container.Bind<IWindowFactory>().To<WindowFactory>().AsSingle();
      Container.Bind<IUIGameLevelViewFactory>().To<UIGameLevelViewFactory>().AsSingle();
      Container.Bind<IUITaskFactory>().To<UITaskFactory>().AsSingle();
    }

    private void BindSoundElements()
    {
      Container.Bind<MainThemeSoundsContainer>().FromInstance(MainThemeSoundsContainer).AsSingle();
    }

    private void BindLevelLoadingElements()
    {
      Container.Bind<LoadingCurtain>().FromInstance(LoadingCurtain).AsSingle();
    }

    public void Initialize()
    {
      Promise.UnhandledException += LogPromiseException;
      Container.Resolve<IGameStateMachine>().Enter<BootstrapState>();
    }

    private void LogPromiseException(object sender, ExceptionEventArgs e)
    {
      Debug.LogError(e.Exception);
    }
  }
}