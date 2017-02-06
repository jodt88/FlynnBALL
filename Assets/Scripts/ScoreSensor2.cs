﻿using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSensor2 : MonoBehaviour
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
            TotalScore.score += 500;
        }
        else
        {
            TotalScore.score -= 500;
        }
    }

    void Update()
    {
        scoreText = GameObject.Find("Score Counter").GetComponent<TextMesh>();
        scoreText.GetComponent<TextMesh>().text = "Score: " + TotalScore.score;
    }
}