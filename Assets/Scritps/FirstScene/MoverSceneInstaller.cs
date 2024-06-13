using UnityEngine;
using Zenject;

public class MoverSceneInstaller : MonoInstaller
{
    [SerializeField] private Mover _mover;
    [SerializeField] private Cube _cube;
    [SerializeField] private ShperePref _shperePref;
    [SerializeField] private CapsulePrefab _capsulePrefab;

    public override void InstallBindings()
    {
        Container.Bind<Mover>().FromInstance(_mover);
        Container.Bind<Cube>().FromInstance(_cube);
        Container.BindFactory<ShperePref, FactroryShpere>().FromComponentInNewPrefab(_shperePref);
        Container.BindMemoryPool<CapsulePrefab, CapsulPool>().FromComponentInNewPrefab(_capsulePrefab);
    }
}