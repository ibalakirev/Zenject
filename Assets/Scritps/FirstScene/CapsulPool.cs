using Zenject;

public class CapsulPool : MemoryPool<CapsulePrefab>
{
    protected override void OnSpawned(CapsulePrefab capsulePref)
    {
        capsulePref.gameObject.SetActive(true);
    }
    protected override void OnDespawned(CapsulePrefab capsulePref)
    {
        capsulePref.gameObject.SetActive(false);
    }
}
