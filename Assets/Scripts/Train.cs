using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    public GameObject[] doors;
    Animator _animator;
    AudioSource _audioSource;
    public GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();

        foreach (GameObject d in doors)
        {
            d.gameObject.SetActive(false);
        }
    }


    void OnTriggerExit(Collider other)
    {
        foreach (GameObject d in doors)
        {
            d.gameObject.SetActive(true);
        }
        _animator.Play("Departure");
        _audioSource.Play();
        barrier.SetActive(true);
    }

    void Delete()
    {
        Destroy(gameObject);
    }
}
