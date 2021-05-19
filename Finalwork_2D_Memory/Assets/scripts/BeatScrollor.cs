using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatScrollor : MonoBehaviour
{
    public float beatTempo;

    public bool hasStarted;

    void Start()
    {
        beatTempo = 6f;
        hasStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted)
        {
            if (Input.anyKeyDown)
                hasStarted = true;
        }
        else
        {
            transform.position -= new Vector3( beatTempo * Time.deltaTime, 0f, 0f );
        }
    }
}
