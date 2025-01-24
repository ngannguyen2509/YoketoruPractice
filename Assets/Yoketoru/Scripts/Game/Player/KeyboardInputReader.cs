using System;
using UnityEngine;

internal class KeyboardInputReader
{
    public Vector3 GetMovementInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        return new Vector3(horizontal, 0, vertical);
    }
}