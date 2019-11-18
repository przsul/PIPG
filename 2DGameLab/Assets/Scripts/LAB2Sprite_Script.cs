using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAB2Sprite_Script : MonoBehaviour
{
    void Update()
    {
        // Obracaj sprite'm po osi Z w lewo
        GetComponent<Renderer>().transform.Rotate(0, 0, 10, Space.Self);

        // Przesun sprite po osi X w prawo
        GetComponent<Renderer>().transform.Translate(0, 0, 0.1f, Space.World);

        // Skaluj sprite po wyszystkich osiach
        GetComponent<Renderer>().transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
