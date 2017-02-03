using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSensor : MonoBehaviour
{
    private int score = 0;

    public GameObject scoreText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "ball")
        {
            score = score + 100;
        }
        else
        {
            score = score - 100;
        }
    }

    void Update()
    {
        scoreText.GetComponent<TextMesh>().text = "Score: " + score;
    } 
}
