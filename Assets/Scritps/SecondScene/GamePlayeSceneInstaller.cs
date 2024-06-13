using Zenject;

public class GamePlayeSceneInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<MovementHandler>().FromNew().AsSingle();
    }
}
