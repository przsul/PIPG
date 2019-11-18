using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBullet : MonoBehaviour
{
    float speed = 0.2f;

    void Update()
    {
        Vector3 position = this.transform.position;
        position.y += speed;
        this.transform.position = position;
    }
}
