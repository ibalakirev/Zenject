using UnityEngine;
using Zenject;

public class ShperePref : MonoBehaviour
{
    private Mover _mover;

    [Inject]

    private void Counstuct(Mover mover)
    {
        _mover = mover;

        Debug.Log("Shpere Inject");
    }

    private void Start()
    {
        _mover.Move();
    }
}
