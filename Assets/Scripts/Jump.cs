using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Jump : MonoBehaviour
{
    private float jump = 4f;
    private Rigidbody2D rb;
    public GameObject gameOver;
    public GameObject towel;

    void Start()
    {
        gameOver.SetActive(!gameOver.activeSelf);
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.velocity = Vector2.up * jump;
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Die"))
        {
            gameOver.SetActive(!gameOver.activeSelf);
            SpriteRenderer myRenderer = GetComponent<SpriteRenderer>();
            myRenderer.enabled = false;
            Destroy(this.GetComponent<Rigidbody2D>());
        }
    }

}
