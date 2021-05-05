using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    [SerializeField]
    Light[] _light;

    void Start()
    {
        _light = transform.GetComponentsInChildren<Light>();
    }

    void FixedUpdate()
    {
        switch(GlobalVariables.SharedInstance.time)
        {
            case GlobalVariables.timeOfDay.Afternoon:
            case GlobalVariables.timeOfDay.Dusk:
                for(int i = 0; i < _light.Length; i++)
                    _light[i].enabled = false;
            break;
            case GlobalVariables.timeOfDay.Evening:
                for(int i = 0; i < _light.Length; i++)
                    _light[i].enabled = true;                   
            break;
        }
    }
}
