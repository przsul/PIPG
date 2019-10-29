﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        }
    }
}
