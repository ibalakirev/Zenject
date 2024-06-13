using UnityEngine;
using Zenject;

public class SphereCreater : MonoBehaviour
{
    [Inject]

    private FactroryShpere _factroryShpere;

    private void Start()
    {
        var go = _factroryShpere.Create();
    }
}
