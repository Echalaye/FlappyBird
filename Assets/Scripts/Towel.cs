using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Towel : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3 (transform.position.x - 0.01f, transform.position.y, transform.position.z);
    }
}

