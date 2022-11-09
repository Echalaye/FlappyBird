using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Jump : MonoBehaviour
{
    private float jump = 5f;
    private Rigidbody2D rb;
    public GameObject gameOver;
    public GameObject towel;
    public TextMeshProUGUI countText;
    private int count = 0;

    void Start()
    {
        gameOver.SetActive(!gameOver.activeSelf);
        rb = GetComponent<Rigidbody2D>();
        countText.text = count.ToString();

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
        if (coll.gameObject.CompareTag("Survive"))
        {
            Debug.Log("test");
            count += 1;
            SetCountText();
        }
        if (coll.gameObject.CompareTag("Die"))
        {
            count = 0;
            SetCountText();
            gameOver.SetActive(!gameOver.activeSelf);
            SpriteRenderer myRenderer = GetComponent<SpriteRenderer>();
            myRenderer.enabled = false;
            Destroy(this.GetComponent<Rigidbody2D>());
        }
    }

    void SetCountText()
    {
        countText.text = count.ToString();
    }

}
