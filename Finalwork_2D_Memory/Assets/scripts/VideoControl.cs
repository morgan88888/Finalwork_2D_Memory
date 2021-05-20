using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private bool start;

    void Start()
    {
        videoPlayer.Pause();
        start = false;
    }

    void Update()
    {
        if(!start)
        {
            if (Input.anyKeyDown)
            {
                videoPlayer.Play();
                start = true;
            }
        }
    }
}
