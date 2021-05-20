using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Unit : MonoBehaviour
{
    public string UnitName;
    public int HP = 100;
    public float Speed = 3;
    public int Atk = 10;
    public int Team = 0;
    void Start()
    {

    }

    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D fuck)
    {
        if (fuck.GetComponent<BulletMove>().Team != Team)//如果Team值不同則受到傷害
        {
            HP -= 40; //生命值-10
            if (HP < 0)
            {
                SceneManager.LoadScene("littleG05");

            }
        }
    }
}