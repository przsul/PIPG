using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class task2_script : MonoBehaviour {

    public float maxSpeed = 4f;
    public float maxRotation = 100f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movingVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        rb.AddForce(movingVector);

        //rb.velocity = movingVector;

        //rb.MovePosition(movingVector);

    }
}
