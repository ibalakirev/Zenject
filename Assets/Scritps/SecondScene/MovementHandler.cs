using UnityEngine;
using System;

public class MovementHandler : IDisposable
{
    private IInput _input;

    public MovementHandler(IInput input)
    {
        _input = input;

        Debug.Log(input.GetType());

        _input.ClickDown += OnClickDown;
        _input.ClickUp += OnClickUp;
    }

    public void Dispose()
    {
        _input.ClickDown -= OnClickDown;
        _input.ClickUp -= OnClickUp;
    }

    private void OnClickDown(Vector3 position)
    {
        Debug.Log("OnClickDown");
    }

    private void OnClickUp(Vector3 position)
    {
        Debug.Log("OnClickUp");
    }
}
