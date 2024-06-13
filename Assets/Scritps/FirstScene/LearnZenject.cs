using UnityEngine;
using Zenject;

public class LearnZenject : MonoBehaviour
{
    private Mover _mover;

    [Inject]

    private void Construct(Mover mover)
    {
        _mover = mover;

        Debug.Log("Learn Инъекция");
    }

    private void Start()
    {
        _mover.Move();

        Debug.Log("LearnMove");
    }
}
