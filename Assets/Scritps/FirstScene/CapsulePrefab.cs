using UnityEngine;
using Zenject;

public class CapsulePrefab : MonoBehaviour
{
    private Mover _mover;

    [Inject]

    private void Counstuct(Mover mover)
    {
        _mover = mover;

        Debug.Log("������� ��������");
    }

    private void Start()
    {
        _mover.Move();
    }
}
