/* ScoreSensor.cs -- A script for increasing or decreasing the player's score by 100. Displays score on start and update.
 * 
 * Written by Jody Toms.
 */

using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSensor4 : MonoBehaviour
{
    public TextMesh scoreText;

    void Start()
    {
        scoreText = GameObject.Find("Score Counter").GetComponent<TextMesh>();
        scoreText.GetComponent<TextMesh>().text = "Score: " + TotalScore.score;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "ball")
        {
            TotalScore.score += 100;
        }
        else
        {
            TotalScore.score -= 100;
        }
    }

    void Update()
    {
        scoreText = GameObject.Find("Score Counter").GetComponent<TextMesh>();
        scoreText.GetComponent<TextMesh>().text = "Score: " + TotalScore.score;
    }
}
