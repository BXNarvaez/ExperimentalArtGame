using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioClip[] songs;
    public int currentSong;
    public AudioSource musicPlayer;

    // Start is called before the first frame update
    void Start()
    {
        currentSong = 0;
        musicPlayer = GetComponent<AudioSource>();
        musicPlayer.clip = songs[currentSong];
        musicPlayer.Play();
    }
}
