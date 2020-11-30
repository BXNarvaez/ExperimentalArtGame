using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class PlayMusic : MonoBehaviour
{
    PlayerControls controls;
    
    public GameObject musicInterface;
    public Button[] buttons;

    void Awake()
    {
        controls = new PlayerControls();

        controls.PlayMusic.Prev.performed += ctx => PressButton(0);
        controls.PlayMusic.Next.performed += ctx => PressButton(3);
        controls.PlayMusic.VolUp.performed += ctx => PressButton(1);
        controls.PlayMusic.VolDown.performed += ctx => PressButton(2);
    }

    void OnEnable()
    {
        controls.PlayMusic.Enable();
    }
    void Start()
    {
        musicInterface = GameObject.Find("MusicInterface");
        buttons = musicInterface.transform.GetComponentsInChildren<Button>();
    }

    void PressButton(int i)
    {
        var eventSystem = EventSystem.current;
        ExecuteEvents.Execute(buttons[i].gameObject, new BaseEventData(eventSystem), ExecuteEvents.submitHandler);
    }
}
