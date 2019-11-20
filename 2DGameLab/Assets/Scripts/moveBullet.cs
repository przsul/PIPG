using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class moveBullet : MonoBehaviour
{

    public AudioClip explosion;
    public static int hits = 0;

    float speed = 0.2f;


    void Update()
    {
        Vector3 position = this.transform.position;
        position.y += speed;
        this.transform.position = position;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        hits++;
        Destroy(col.gameObject);
        Destroy(gameObject);
        Vector3 cameraZPos = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);

        AudioSource.PlayClipAtPoint(explosion, cameraZPos, 1f);
    }
}
