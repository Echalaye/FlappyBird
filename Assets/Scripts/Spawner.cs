using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private double queueTime = 0.8;
    private float time = 0;
    public GameObject obstacle;
    public GameObject gameOver;

    // Update is called once per frame
    void Update()
    {
        if (!gameOver.activeSelf)
        {
            if (time > queueTime)
            {
                GameObject go = Instantiate(obstacle);
                go.transform.position = transform.position + new Vector3(0, Random.Range(-2, 2), 0);

                time = 0;

            }

            time += Time.deltaTime;
        }

    }
}
