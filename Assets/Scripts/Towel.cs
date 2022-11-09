using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towel : MonoBehaviour
{
    private static float vitesse = 0.013f;

    void Update()
    {
        transform.position = new Vector3 (transform.position.x - vitesse, transform.position.y, transform.position.z);
    }
}

