using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class onto3F05 : MonoBehaviour
{
    public GameObject Button;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Button.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Button.SetActive(false);
    }


    private void Update()
    {
        if (Button.activeSelf && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("3F05");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Button.SetActive(false);
        }
    }
}