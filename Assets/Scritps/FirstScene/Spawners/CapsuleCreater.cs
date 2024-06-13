using System.Collections;
using UnityEngine;
using Zenject;

public class CapsuleCreater : MonoBehaviour
{
    private CapsulePrefab _currentCapsule;

    [Inject]

    private CapsulPool _pool;

    private void Start()
    {
        _currentCapsule = _pool.Spawn();

        StartCoroutine(Despawner());
    }

    private IEnumerator Despawner()
    {
        WaitForSeconds timeWait = new WaitForSeconds(5);

        yield return timeWait;

        _pool.Despawn(_currentCapsule);
    }
}
