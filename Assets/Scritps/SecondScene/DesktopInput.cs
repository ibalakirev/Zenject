using System;
using UnityEngine;

public class DesktopInput : IInput
{
    public event Action<Vector3> ClickDown;
    public event Action<Vector3> ClickUp;
}
