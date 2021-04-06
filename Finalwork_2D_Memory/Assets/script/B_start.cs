using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_start : MonoBehaviour
{
    public Animator crossfade;
    float waitTime = 3.25f;
    public void BtnNewScene()
    {
        StartCoroutine(LoadCH1());
    }

    IEnumerator LoadCH1()
    {
        crossfade.SetTrigger("crossfadeStart");

        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene("op");
    }

}
