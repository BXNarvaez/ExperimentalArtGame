using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class PlayMusic : MonoBehaviour
{
    PlayerControls controls;
    public AudioClip[] songs;
    public int currentSong;
    public AudioSource musicPlayer;
    
    public GameObject musicInterface;
    public Button[] buttons;

    void Awake()
    {
        controls = new PlayerControls();

        controls.PlayMusic.Prev.performed += ctx => PressButton(0);
        controls.PlayMusic.Next.performed += ctx => PressButton(3);
        controls.PlayMusic.VolUp.performed += ctx => PressButton(1);
        controls.PlayMusic.VolDown.performed += ctx => PressButton(2);
        controls.PlayMusic.PlayPause.performed += ctx => PlayPause(); //update later
    }

    void OnEnable()
    {
        controls.PlayMusic.Enable();
    }
    void Start()
    {
        musicInterface = GameObject.Find("MusicInterface");
        buttons = musicInterface.transform.GetComponentsInChildren<Button>();

        musicPlayer = GameObject.Find("Headphones").GetComponent<AudioSource>();
            
        currentSong = 0;
        musicPlayer.clip = songs[currentSong];
        musicPlayer.Play();
    }

    void PressButton(int i)
    {
        var eventSystem = EventSystem.current;
        ExecuteEvents.Execute(buttons[i].gameObject, new BaseEventData(eventSystem), ExecuteEvents.submitHandler);
    }

    public void Prev()
    {
        if(currentSong > 0)
            currentSong--;
        else if(currentSong == 0)
        {
            currentSong = songs.Length - 1;
        }

        musicPlayer.clip = songs[currentSong];
        musicPlayer.Play();
    }
    public void Next()
    {
        if(currentSong < songs.Length - 1)
            currentSong++;
        else if(currentSong == songs.Length - 1)
        {
            currentSong = 0;
        }

        musicPlayer.clip = songs[currentSong];
        musicPlayer.Play();
    }
    public void VolUp()
    {
        musicPlayer.volume += 0.1f;
    }
    public void VolDown()
    {
        musicPlayer.volume -= 0.1f;
    }

    public void PlayPause()
    {
        if(musicPlayer.isPlaying)
            musicPlayer.Pause();
        else
            musicPlayer.UnPause();
    }
}
