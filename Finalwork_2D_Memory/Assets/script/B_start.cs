using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_start : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("game");
    }

}
