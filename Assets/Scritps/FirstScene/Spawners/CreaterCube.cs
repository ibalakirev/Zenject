using UnityEngine;
using Zenject;

public class CreaterCube : MonoBehaviour
{
    [SerializeField] private Transform _transform;
    [SerializeField] private Cube _cube;

    [Inject]

    private DiContainer _container;

    private void Start()
    {
        var go = _container.InstantiatePrefab(_cube, _transform);
    }
}
