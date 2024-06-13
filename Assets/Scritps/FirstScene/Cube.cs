using UnityEngine;
using Zenject;

public class Cube : MonoBehaviour
{
    private Mover _mover;

    [Inject]

    private void Construct(Mover mover)
    {
        _mover = mover;

        Debug.Log("Инъекция куба");
    }

    private void Start()
    {
        _mover.Move();

        Debug.Log("Вызов метода Мувер");
    }
}
