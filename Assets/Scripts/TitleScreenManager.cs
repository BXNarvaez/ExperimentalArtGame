using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenManager : MonoBehaviour
{
    private TransitionManager _transitionManager;

    void Start()
    {
        _transitionManager = FindObjectOfType<TransitionManager>();
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
}
