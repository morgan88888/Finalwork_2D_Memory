using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public GameObject camara;
    public AudioSource music;

    private bool start;

    void Start()
    {
        music = camara.GetComponent<AudioSource>();
        music.Pause();
        start = false;
    }

    void Update()
    {
        if(!start)
        {
            if (Input.anyKeyDown)
            {
                music.Play();
                start = true;
            }
        }
    }
}
