using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B_back : MonoBehaviour
{
    public void BtnNewScene()
    {
        SceneManager.LoadScene("start");
    }

}
