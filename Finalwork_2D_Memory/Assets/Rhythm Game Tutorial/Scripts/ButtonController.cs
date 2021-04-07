using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {
   
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode KeyToPress;
    
    void Start(){
        theSR = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyToPress))
        {
            theSR.sprite = pressedImage;
        }

        if(Input.GetKeyUp(KeyToPress))
        {
            theSR.sprite = defaultImage;
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
