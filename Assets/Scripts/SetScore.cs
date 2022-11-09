using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    public static int score = 0;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
