using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class moveBullet : MonoBehaviour
{

    public AudioClip explosion;

    float speed = 0.2f;

    void Update()
    {
        Vector3 position = this.transform.position;
        position.y += speed;
        this.transform.position = position;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        AudioSource.PlayClipAtPoint(explosion, gameObject.transform.position);
        Destroy(gameObject);
    }
}
