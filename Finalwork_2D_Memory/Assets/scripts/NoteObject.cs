using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{

    public bool canBePressed;

    public KeyCode keyToPress;

    public GameObject whiteBar;
    public Animator whiteAni;

    // Start is called before the first frame update
    void Start()
    {
        whiteAni = whiteBar.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                whiteAni.SetBool("hit", true);
                whiteAni.SetTrigger("press");
                PlayTheGame.instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(gameObject.active)
        {
            if (other.tag == "Activator")
            {
                canBePressed = false;
                whiteAni.SetBool("hit", false);
                whiteAni.SetTrigger("press");
                PlayTheGame.instance.NoteMiss();
            }
        }
    }
}
