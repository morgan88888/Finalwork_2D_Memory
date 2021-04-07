using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour

{
    public AudioSource theMusic;

    public bool startplaying;

    public BeatScroller theBS;

    public static GameManger instance;

    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerGoodNote = 125;


    public int currentMultiplier;
    public int multiolierTracker;
    public int[] multiplierThresholds;


    public Text scoreText;
    public Text multiText;

    public float TotolNotes;
    public float normalHitss;
    public float goodHits;
    public float missedHits;

    public GameManger resultsScreen;
    public Text precenHitText, normalsText, goodsText, missesText;

    public GameObject GAMEOVER;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        scoreText.text = "Score: 0";
        currentMultiplier = 1;

        TotolNotes = FindObjectOfType<NoteObject>().Length;

    }

    // Update is called once per frame
    void Update()
    {
        if (!startplaying)
        {
            if (Input.anyKeyDown)
            {
                startplaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
        else
        {
            if (!theMusic.isPlaying)
            {
                SceneManager.LoadScene(1);
            }

        }


        {

        }

    }
    public void NoteHit()
    {
        Debug.Log("Hit On Time");

        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {

            multiolierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiolierTracker)
            {
                multiolierTracker = 0;
                currentMultiplier++;
            }
        }

        multiText.text = "Mutiplier: x" + currentMultiplier;

        //currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score: " + currentScore;
    }
    public void NormalHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();

        normalHitss++;
    }
    public void GoodHit()
    {
        currentScore += scorePerGoodNote * currentMultiplier;
        NoteHit();

        goodHits++;
    }
    public void NoteMissed()
    {
        Debug.Log("Missde Note");

        currentMultiplier = 1;
        multiolierTracker = 0;

        multiText.text = "Multiplier :x" + currentMultiplier;

        missedHits++;




    }


    enum tags
    {
        箭頭
    }








}