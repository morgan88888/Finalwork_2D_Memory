using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Esc_quit : MonoBehaviour
{
    public GameObject pausemMenu;
    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            pausemMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
        }
    }

    public void StartGame()
    {
        pausemMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("start");
        Time.timeScale = 1f;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
