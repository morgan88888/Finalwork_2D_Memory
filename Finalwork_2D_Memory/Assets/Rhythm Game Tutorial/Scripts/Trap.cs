using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour


{
    public int life;
    public GameObject GAMEOVER;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.CompareTag("箭頭"))
        {
            life--;
        }
        if (life >= 5)
        {
            GAMEOVER.SetActive(true);
        }
        
    }

}
