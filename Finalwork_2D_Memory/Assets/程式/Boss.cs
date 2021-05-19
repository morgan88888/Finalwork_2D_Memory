using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public int Team = 0;


    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D fuckyou)
        {
            if (fuckyou.GetComponent<BulletMove>().Team != Team)//如果Team值不同則受到傷害
            {

                SceneManager.LoadScene("CH02afterLG05");

            }
        }
}
