using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Uduino;

public class DigitalButtonClass : MonoBehaviour
{
    public int pinNumber;
    public int newButtonState = 0;
    public int currentButtonState = 0;
    

    public void InitializePin(int pin)
    {
        UduinoManager.Instance.pinMode(pin, PinMode.Input_pullup);
        pinNumber = pin;
    }
}
