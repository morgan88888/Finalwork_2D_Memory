using UnityEngine;
using System.Collections;
public class Shooting : MonoBehaviour
{
    public GameObject Bullet; //子彈物件
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            GameObject bullet = (GameObject)Instantiate(Bullet,
                transform.position, new Quaternion(0, 0, 0, 0));
            //克隆一個Bullet在小飛兵的位置，轉型成GameObject型態將值給予bullet
            bullet.GetComponent<BulletMove>().Team = GetComponent<Unit>().Team;
            //設定bullet的BulletMove中的Team值 為 此物件的Unit的Team
        }
    }
}