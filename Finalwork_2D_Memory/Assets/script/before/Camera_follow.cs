using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Transform Main_Camera;
    
    void Update()
    {
        transform.position = new Vector4(player.position.x + offset.x, offset.y, offset.z);
    }
}
