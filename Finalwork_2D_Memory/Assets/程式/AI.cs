using UnityEngine;
using System.Collections;
public class AI : MonoBehaviour
{
    float posX = 0;
    float LocateTime = 0;
    float LocateNeedTime = 1;
    float ShootingTime = 0.6f;
    float ShootingNeedTime = 0.6f;
    public GameObject BulletB;
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        AITime();
        AIMove();
        AIShooting();
    }
    void AIShooting()
    {
        if (ShootingTime <= 0)  //ShootingTime <= 0
        {
            ShootingTime = ShootingNeedTime;  //設定ShootingTime為ShootingNeedTime
            GameObject bullet = (GameObject)Instantiate(BulletB,
                transform.position, new Quaternion(0, 0, 0, 0));
            //克隆一個Bullet在小飛兵的位置，轉型成GameObject型態將值給予bullet
            bullet.GetComponent<BulletMove>().Team = GetComponent<Unit>().Team;
            //設定bullet的BulletMove中的Team值 為 此物件的Unit的Team
            bullet.transform.Rotate(0, 0, 180);//旋轉180度

        }
        else //否則ShootingTime減去Time.deltaTime達成計時效果
        {
            ShootingTime -= Time.deltaTime;
        }
    }
    void AITime()
    {
        if (LocateTime <= 0)  //如果LocateTime <= 0
        {
            LocateTime = LocateNeedTime;  //設定LocateTime為LocateNeedTime
            posX = Random.Range(-8, 8); //讓posX為亂數-3~3
        }
        else //否則LocateTime減去Time.deltaTime達成計時效果
        {
            LocateTime -= Time.deltaTime;
        }
    }
    void AIMove()
    {
        float speed = GetComponent<Unit>().Speed;//取得速度
        //如果posX與物件的x座標相減後取絕對值 大於0.1 則開始做移動判斷
        if (Mathf.Abs(posX - transform.position.x) > 0.1f)
        {
            if (posX < transform.position.x) //左邊
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else //右邊
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
        }
    }
}