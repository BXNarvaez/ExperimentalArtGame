using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Uduino;
using UnityEngine.EventSystems;

public class PlayMusicArduino : MonoBehaviour
{
    public AudioClip[] songs;
    public int currentSong;
    public AudioSource musicPlayer;
    string status;

    //Interface
    public GameObject musicInterface;
    public Button[] buttons;
    public Button playPause;
    public Image ppImage;
    public Sprite[] icons;
    public Slider songLength;
    public Text songName;

    //Arduino
    public List<DigitalButtonClass> _digitalButtons;

    void Start()
    {
        musicInterface = GameObject.Find("MusicInterfaceArduino");
        buttons = musicInterface.transform.GetComponentsInChildren<Button>();
        musicPlayer = GameObject.Find("Headphones").GetComponent<AudioSource>();

        if(GlobalVariables.SharedInstance.mode != GlobalVariables.controllerMode.Arduino)
        {
            musicInterface.SetActive(false);
            playPause.gameObject.SetActive(false);
            this.enabled = false;
        }
        
        status = "Playing";
            
        currentSong = 0;
        musicPlayer.clip = songs[currentSong];
        musicPlayer.Play();

        for(int i = 0; i < 4; i++)
        {
            _digitalButtons.Add(buttons[i].GetComponent<DigitalButtonClass>());
            _digitalButtons[i].InitializePin(i + 2);
        }

        _digitalButtons.Add(playPause.gameObject.GetComponent<DigitalButtonClass>());
        _digitalButtons[4].InitializePin(6);
    }

    void LateUpdate()
    {
        foreach (DigitalButtonClass button in _digitalButtons)
        {
            button.newButtonState = UduinoManager.Instance.digitalRead(button.pinNumber);
            if(button.newButtonState != button.currentButtonState)
            {        
                if(button.newButtonState == 0)
                    PressButton(button.pinNumber - 2);
            }
            button.currentButtonState = button.newButtonState;
        }

        songName.text = "Track " + (currentSong + 1);
        if(musicPlayer.isPlaying)
        {
            songLength.value += Time.deltaTime;
        }

        songLength.maxValue = musicPlayer.clip.length;

        if(!musicPlayer.isPlaying)
            OnSongEnd(status);
    }

    void PressButton(int i)
    {
        var eventSystem = EventSystem.current;
        ExecuteEvents.Execute(_digitalButtons[i].gameObject, new BaseEventData(eventSystem), ExecuteEvents.submitHandler);
    }

    public void Prev()
    {
        songLength.value = 0;
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
        songLength.value = 0;
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
        //var eventSystem = EventSystem.current;
        //ExecuteEvents.Execute(playPause.gameObject, new BaseEventData(eventSystem), ExecuteEvents.submitHandler);
        
        if(musicPlayer.isPlaying)
        {
            status = "Paused";
            musicPlayer.Pause();
            ppImage.sprite = icons[0];
        }
        else
        {
            status = "Playing";
            musicPlayer.UnPause();
            ppImage.sprite = icons[1];
        }
    }

    public void OnSongEnd(string _status)
    {
        if(!musicPlayer.isPlaying && _status == "Playing")
            Next();
        else
            return;
    }
}
