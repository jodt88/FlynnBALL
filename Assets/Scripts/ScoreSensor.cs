using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSensor : MonoBehaviour
{
    public TextMesh scoreText;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "ball")
        {
            TotalScore.score += 100;
        }
        else
        {
            TotalScore.score -= 100;
        }
        scoreText = GameObject.Find("Score Counter").GetComponent<TextMesh>();
        scoreText.GetComponent<TextMesh>().text = "Score: " + TotalScore.score;
    }
}
