using System;
using UnityEngine;

internal class MouseInputReader
{
    public Vector3 GetMovementInput()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");

        return new Vector3(horizontal, 0, vertical);
    }
}