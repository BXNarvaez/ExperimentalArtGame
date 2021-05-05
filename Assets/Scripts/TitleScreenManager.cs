using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TitleScreenManager : MonoBehaviour
{
    private TransitionManager _transitionManager;

    public Dropdown _timeOfDay, _controllerMode;

    void Start()
    {
        _transitionManager = FindObjectOfType<TransitionManager>();
        CreateList();
    }

    //Title Screen Buttons
    public void GameStart()
    {
        _transitionManager.NextScene("TrainStation");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _transitionManager.NextScene("TitleScreen");
        }
    }

    public void TimeIndexChanged(int index)
    {
        GlobalVariables.SharedInstance.time = (GlobalVariables.timeOfDay)index;
    }
    public void ModeIndexChanged(int index)
    {
        GlobalVariables.SharedInstance.mode = (GlobalVariables.controllerMode)index;
    }

    void CreateList()
    {
        string[] timeEnumNames = Enum.GetNames(typeof(GlobalVariables.timeOfDay));
        List<string> timeNames = new List<string>(timeEnumNames);
        _timeOfDay.AddOptions(timeNames);

        string[] modeEnumNames = Enum.GetNames(typeof(GlobalVariables.controllerMode));
        List<string> modeNames = new List<string>(modeEnumNames);
        _controllerMode.AddOptions(modeNames);
    }
}
