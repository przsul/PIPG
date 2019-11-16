using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject bulletPreFab;
    private GameObject player;
    private float playerX;
    private float playerY;
    private float playerBoundX;
    private float playerBoundY;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        playerBoundX = player.GetComponent<SpriteRenderer>().bounds.size.x;
        playerBoundY = player.GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        playerX = player.transform.position.x;
        playerY = player.transform.position.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jestem tutaj: "  + GameObject.FindGameObjectsWithTag("Player").Length);
            Debug.Log("PlayerX: " + playerX);
            Debug.Log("PlayerY: " + playerY);
            Instantiate(bulletPreFab, new Vector3(playerX, playerY + (playerBoundY*0.8f), 0), Quaternion.identity);
        }
    }
}
