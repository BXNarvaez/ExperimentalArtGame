using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public static GlobalVariables SharedInstance;
    public enum timeOfDay {Afternoon, Dusk, Evening}
    public timeOfDay time;

    public enum controllerMode {Gamepad, Arduino}
    public controllerMode mode;

    [SerializeField]
    Light _directionalLight;
    [SerializeField]
    Color[] skyColor;
    [SerializeField]
    Material _material;
    [SerializeField]
    Color[] _lightColor;

    void Awake()
    {
        if (FindObjectsOfType<GlobalVariables>().Length > 1)
            Destroy(gameObject);

        if(SharedInstance == null)
            SharedInstance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        _directionalLight = GameObject.Find("Directional Light").GetComponent<Light>();
    }
    void FixedUpdate()
    {
        switch(GlobalVariables.SharedInstance.time)
        {
            case GlobalVariables.timeOfDay.Afternoon:
                RenderSettings.skybox.SetColor("_Tint", skyColor[0]);
                _directionalLight.color = skyColor[1];
                _material.SetColor("_EmissionColor", _lightColor[0]);
            break;
            case GlobalVariables.timeOfDay.Dusk:
                RenderSettings.skybox.SetColor("_Tint", skyColor[2]);
                _directionalLight.color = skyColor[3];
                _material.SetColor("_EmissionColor", _lightColor[0]);
            break;
            case GlobalVariables.timeOfDay.Evening:
                RenderSettings.skybox.SetColor("_Tint", skyColor[4]);
                _directionalLight.color = skyColor[5];
                _material.SetColor("_EmissionColor", _lightColor[1]);               
            break;
        }
    }
}
