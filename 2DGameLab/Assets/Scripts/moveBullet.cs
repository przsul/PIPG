using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class moveBullet : MonoBehaviour
{

    public AudioClip explosion;
    AudioSource audioSource;
    public static int hits = 0;

    float speed = 0.2f;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
        gameObject.SetActive(false);
        audioSource.PlayOneShot(explosion, 1f);
        Destroy(gameObject, 3f);
    }
}
