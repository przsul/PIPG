using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class result : MonoBehaviour
{
    public TextMeshProUGUI result_score;
    // Start is called before the first frame update
    void Start()
    {
        result_score.text = "Result: " + moveBullet.hits.ToString();
        stateczekBehaviour.lifes = 3;
        moveBullet.hits = 0;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            SceneManager.LoadScene(0);
    }
}
