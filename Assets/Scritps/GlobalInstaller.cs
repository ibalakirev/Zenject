using UnityEngine;
using Zenject;

public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        if (SystemInfo.deviceType == DeviceType.Handheld)
        {
            Container.Bind<IInput>().To<MobileInput>().FromNew().AsSingle();
        }
        else
        {
            Container.Bind<IInput>().To<DesktopInput>().FromNew().AsSingle();
        }
    }
}
