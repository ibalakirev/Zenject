using UnityEngine;
using Zenject;

public class LearnSceneInstaller : MonoInstaller
{
    [SerializeField] private LearnZenject _learnZenject;

    public override void InstallBindings()
    {
        Container.Bind<LearnZenject>().FromInstance(_learnZenject);
    }
}
