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
    string status;

    //Interface
    public GameObject musicInterface;
    public Button[] buttons;
    public Button playPause;
    public Image ppImage;
    public Sprite[] icons;
    public Slider songLength;
    public Text songName;
    

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
        
        status = "Playing";
            
        currentSong = 0;
        musicPlayer.clip = songs[currentSong];
        musicPlayer.Play();
    }

    void LateUpdate()
    {   
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
        ExecuteEvents.Execute(buttons[i].gameObject, new BaseEventData(eventSystem), ExecuteEvents.submitHandler);
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
        var eventSystem = EventSystem.current;
        ExecuteEvents.Execute(playPause.gameObject, new BaseEventData(eventSystem), ExecuteEvents.submitHandler);
        
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
