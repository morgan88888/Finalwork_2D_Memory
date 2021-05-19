using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishNote : MonoBehaviour
{
    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            PlayTheGame.instance.GameFinish();
        }
    }
}
