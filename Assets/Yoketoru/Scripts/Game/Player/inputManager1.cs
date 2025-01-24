using System;
using UnityEngine;

internal class inputManager
{
    private IInput inputReader;

    void Start()
    {
        
        //inputReader = GetComponent<KeyboardInputReader>();  
    }

    void Update()
    {
        
        Vector3 movement = inputReader.GetMovementInput();

       
    }

    
    public void SwitchInputDevice(IInput newInputReader)
    {
        inputReader = newInputReader;
    }

    internal static Vector3 GetMovementInput()
    {
        throw new NotImplementedException();
    }
}