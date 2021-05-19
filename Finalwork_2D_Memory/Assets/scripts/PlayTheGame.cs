using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayTheGame : MonoBehaviour
{
    //Dialog renderer
    public GameObject diaLog;
    private SpriteRenderer diaSR;
    public Sprite diaStart;
    public Sprite diaWin;
    public Sprite diaLose;
    public Sprite diaNone;
    private bool start;

    //Circle renderer
    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite pressedImage;

    public KeyCode D;
    public KeyCode F;
    public KeyCode J;
    public KeyCode K;

    public static PlayTheGame instance;

    //Object for score
    public GameObject scoreHead;
    public GameObject scoreBar;
    private int score;

    //UI image
    public GameObject imageBG;

    void Start()
    {
        imageBG.SetActive(true);
        theSR = GetComponent<SpriteRenderer>();
        diaSR = diaLog.GetComponent<SpriteRenderer>();
        diaSR.sprite = diaStart;
        start = false;
        instance = this;
        score = 0;
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            if(!start)
            {
                imageBG.SetActive(false);
                diaSR.sprite = diaNone;
                start = true;
            }
        }

        if (Input.GetKeyDown(D) | Input.GetKeyDown(F) | Input.GetKeyDown(J) | Input.GetKeyDown(K))
        {
            theSR.sprite = pressedImage;
        }

        if (Input.GetKeyUp(D) | Input.GetKeyUp(F) | Input.GetKeyUp(J) | Input.GetKeyUp(K))
        {
            theSR.sprite = defaultImage;
        }
    }

    public void NoteHit()
    {
        Debug.Log("Hit !!");
        scoreHead.transform.position += new Vector3(0.2041f * scoreBar.transform.localScale.x, 0f, 0f);
        score++;
    }

    public void NoteMiss()
    {
        Debug.Log("Miss..");
    }

    public void GameFinish()
    {
        if(score < 34f)
        {
            StartCoroutine(GameOverLose());
        }
        else
        {
            StartCoroutine(GameOverWin());
        }
    }

    private IEnumerator GameOverLose()
    {
        diaSR.sprite = diaLose;
        yield return waitForKeyPress();
        SceneManager.LoadScene("RhythmGame");
    }

    private IEnumerator GameOverWin()
    {
        diaSR.sprite = diaWin;
        yield return waitForKeyPress();
        SceneManager.LoadScene("afterLG02");
    }

    private IEnumerator waitForKeyPress()
    {
        bool done = false;
        while (!done)
        {
            if (Input.anyKeyDown)
            {
                done = true;
            }
            yield return null;
        }
    }
}
