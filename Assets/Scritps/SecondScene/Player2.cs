using UnityEngine;
using Zenject;

public class Player2 : MonoBehaviour
{
    private MovementHandler _movementHandler;

    [Inject]
    private void Construct(MovementHandler movementHandler)
    {
        _movementHandler = movementHandler;

        Debug.Log("Заинджектили");
    }
}
